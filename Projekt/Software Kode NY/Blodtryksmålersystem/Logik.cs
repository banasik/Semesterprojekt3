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
        private Queue<double> minKø;
        private double gennemsnitKø;
        //private Thread updateDia;
        //private Thread updateSys;
        private double kalibreringKoef;
        private List<IObserver> observers;
        private List<double> FiltreretListe;
        int counter;
        int counter1;
        public double diastoleVærdi;
        public double systoleVærdi;
        private double beregnetNværdi;
        private Analyse AnalyseKlasse = new Analyse();
        public bool RadioProp { get; set; }
        
        public List<double> GennemsnitListe;

        public Logik()
        {
            updateUI = new Thread(() => updateListe());
            //updateDia = new Thread(() => getDia());
            //updateSys = new Thread(() => getSys());
            //updateUI.Start();
            kalibreringKoef = KalibreringObjekt.Kalibrer();
            UILISTE = new List<double>();
            GennemsnitListe = new List<double>();
            observers = new List<IObserver>();
            FiltreretListe = new List<double>();
            minKø = new Queue<double>(100);
            DAQdata.Attach(this);

            diastoleVærdi = new double();
            systoleVærdi = new double();
            for (int i = 0; i < 299; i++)
            {
                UILISTE.Add(0);
            }
            counter1 = 0;
            counter = 0;
            
        }

        public void StartTraad()
        {
            updateUI.Start();
            //updateDia.Start();
            //updateSys.Start();
        }

        

        private void updateListe()
        {
            while (isRunningLogik())
            {
                if (minKø.Count > 0)
                {
                    //GennemsnitListe.Add(((minKø.Dequeue() + beregnetNværdi) * KalibreringObjekt.Kalibrer()));
                    double gennemsnitKø = minKø.Dequeue();
                    gennemsnitKø = (gennemsnitKø + beregnetNværdi) * KalibreringObjekt.Kalibrer();

                    
                        if (counter < 300)
                        {
                            UILISTE[counter] = gennemsnitKø;
                            //UILISTE[counter] = (GennemsnitListe[GennemsnitListe.Count() - 1]);
                            counter++;
                        }
                        if (counter == 299)
                        {
                            counter = 0;
                        }
                    }
                    if (RadioProp == true)
                    {
                        Notify(FiltreringLogik(UILISTE));
                    }
                    else
                    {
                        Notify(UILISTE);
                    }
                }
        
        
                //for (int i = 0; i < GennemsnitListe.Count; i++)
                //{
                //    GennemsnitListe[i] = (GennemsnitListe[i] + beregnetNværdi);
                //    GennemsnitListe[i] = (GennemsnitListe[i] * KalibreringObjekt.Kalibrer());
                //}
            //Ved tilføjelse af radiobuttons, skal der laves en if/else sådan at en property bliver sat til true/false om et filtreret
                // signal skal sendes op eller ej.




                Thread.Sleep(5);
            }
        
        

        public void getDia()
        {
            AnalyseKlasse.Diastole(UILISTE);
            diastoleVærdi = AnalyseKlasse.Diastole_;
        }
        public void getSys()
        {
            AnalyseKlasse.Systole(UILISTE);
            systoleVærdi = AnalyseKlasse.Systole_;
        }


        public List<double> UILISTE;
        public bool isRunningLogik()
        {
            return DAQdata.IsRunning();
        }

        public void getListLogik()
        {
            DAQdata.getList();
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

        public void gemData(string forsøgsnavn, int autogenereretNR, List<double> samplelist)
        {
            Database.gemData(forsøgsnavn, autogenereretNR, samplelist);
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
            minKø.Enqueue(Convert.ToDouble(graf.Average()));
           // GennemsnitListe.Add(Convert.ToDouble(graf.Average()));
            //Der skal laves en queue i stedet for en liste hernede. GennemsnitListe skal fjernes.
        }
        public void nulpunktsJustering(double værdi)
        {
            beregnetNværdi = NulpunktObjekt.Justering(værdi);
        }

        public List<double> FiltreringLogik(List<double> data)
        {
            FiltreretListe = FilterObj.Filtrering(data);
            return FiltreretListe;
        }
        
    
    }
}