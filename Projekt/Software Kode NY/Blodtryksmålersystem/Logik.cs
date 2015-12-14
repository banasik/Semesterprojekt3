using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Threading;
using DTO;

namespace LogikLag
{
    public class Logik : ISubject, IObserver
    {
        private DatabaseAdgang Database = new DatabaseAdgang();
        private IndhentDAQData DAQdata = new IndhentDAQData();
        private Nulpunktsjustering NulpunktObjekt = new Nulpunktsjustering();
        private Kalibrering KalibreringObjekt = new Kalibrering();
        private Filter FilterObj = new Filter();
        private Thread updateUI;
        private Thread updateNul;
        private Queue<double> minKø;
        private double kalibreringKoef;
        private List<IObserver> observers;
        private List<double> FiltreretListe;
        private List<double> databasetal;
        int counter;
        
        public double DiastoleVærdi { get; set; }
        public double SystoleVærdi { get; set; }
        private double beregnetNværdi;
        private Analyse AnalyseKlasse = new Analyse();
        public bool RadioProp { get; set; }
        
        
        public Logik()
        {
            beregnetNværdi = 0.0;
            updateUI = new Thread(() => updateListe());
            kalibreringKoef = KalibreringObjekt.Kalibrer();
            UILISTE = new List<double>();
            observers = new List<IObserver>();
            FiltreretListe = new List<double>();
            databasetal = new List<double>();
            minKø = new Queue<double>(100);
            DAQdata.Attach(this);
            for (int i = 0; i < 299; i++)
            {
                UILISTE.Add(0);
            }
            counter = 0;
        }

        public void StartTraad()
        {
            updateUI.Start();
        }

        private List<double> UILISTE;

        private void updateListe()
        {
            while (isRunningLogik())
            {
                if (minKø.Count > 0)
                {
                    double gennemsnitKø = minKø.Dequeue();
                    gennemsnitKø = (gennemsnitKø + beregnetNværdi) * kalibreringKoef;

                    if (counter < 300)
                    {
                        UILISTE[counter] = gennemsnitKø;
                        counter++;
                    }
                    if (counter == 299)
                    {
                        counter = 0;
                    }
                }
                if (RadioProp == false)
                {
                    Notify(FiltreringLogik(UILISTE));
                }
                else
                {
                    Notify(UILISTE);
                }
            }
            Thread.Sleep(5);
        }
        
        public void getDia()
        {
            AnalyseKlasse.Diastole(FiltreringLogik(UILISTE));
            DiastoleVærdi = AnalyseKlasse.Diastole_;
        }
        public void getSys()
        {
            AnalyseKlasse.Systole(FiltreringLogik(UILISTE));
            SystoleVærdi = AnalyseKlasse.Systole_;
        }

        public bool isRunningLogik()
        {
            return DAQdata.IsRunning();
        }

        public void indhentDataLogik()
        {
            DAQdata.indhentData();
        }

        public void stopReadDataLogik()
        {
            DAQdata.stopReadData();
            updateUI.Abort();
        }

        public int gemData(string forsøgsnavn) 
        {
            return Database.gemData(forsøgsnavn, databasetal);
        }

        public void ClearData()
        {
            databasetal.Clear();
        }
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify(List<double> data)
        {

            foreach (IObserver obs in observers)
            {
                obs.Gennemsnit(data);
            }
        }
        public void Gennemsnit(List<double> graf)
        {
            databasetal = graf;
            minKø.Enqueue(Convert.ToDouble(graf.Average()));
        }
        public void StartNulPunkt()
        {
             {
            DAQdata.indhentData();
            updateNul = new Thread(() => nulpunktsJustering());
            updateNul.Start();
             }
        }
        public void nulpunktsJustering()
        {
            while(isRunningLogik())
            {
                if(minKø.Count > 0)
                {
                    DAQdata.stopReadData();
                    beregnetNværdi = NulpunktObjekt.Justering((minKø.Dequeue()));
                    minKø.Clear();
                    updateNul.Abort();
                }
                Thread.Sleep(2);
            }
        }

        private List<double> FiltreringLogik(List<double> data)
        {
            FiltreretListe = FilterObj.Filtrering(data);
            return FiltreretListe;
        }
        
    }
}