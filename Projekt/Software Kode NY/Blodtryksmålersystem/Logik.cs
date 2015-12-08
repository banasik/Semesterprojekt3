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
        private Thread updateUI;
        private Thread updateDia;
        private Thread updateSys;
        private double kalibreringKoef;
        private List<IObserver> observers;
        int counter;
        int counter1;
        public double diastoleVærdi;
        public double systoleVærdi;
        private double beregnetNværdi;
        private Analyse AnalyseKlasse = new Analyse();
        private Nulpunktsjustering NulpunktObjekt = new Nulpunktsjustering();
        private Kalibrering KalibreringObjekt = new Kalibrering();
        public List<double> GennemsnitListe;

        public Logik()
        {
            updateUI = new Thread(() => updateListe());
            updateDia = new Thread(() => getDia());
            updateSys = new Thread(() => getSys());
            //updateUI.Start();
            kalibreringKoef = KalibreringObjekt.Kalibrer();
            UILISTE = new List<double>();
            GennemsnitListe = new List<double>();
            observers = new List<IObserver>();
            
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
            updateDia.Start();
            updateSys.Start();
        }

        

        private void updateListe()
        {
            while (isRunningLogik())
            {
                
                for (int i = 0; i < GennemsnitListe.Count; i++)
                {
                    GennemsnitListe[i] = (GennemsnitListe[i] + beregnetNværdi);
                    GennemsnitListe[i] = (GennemsnitListe[i] * KalibreringObjekt.Kalibrer());
                }
            
                if (GennemsnitListe.Count > 0 && counter1 < 300)
                {
                    
                   UILISTE[counter1] = (GennemsnitListe[GennemsnitListe.Count -1]);
                   counter1++;
                   counter++;
                    Notify(UILISTE);
                }

                if (counter1 == 299)
                {
                    counter1 = 0;
                }
                //}
                //Subject.Value = uiList;
                //updateChart();
                //Thread.Sleep(1);                
            }
        
        
        
        
        
        }

        public void getDia()
        {
            AnalyseKlasse.Diastole(UILISTE);
            diastoleVærdi = AnalyseKlasse.Diastole_;

            //while (isRunningLogik())
            //{
            //   AnalyseKlasse.Diastole(diastoleListe);
            //}
            //return AnalyseKlasse.Diastole_;
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
            GennemsnitListe.Add(Convert.ToDouble(graf.Average()));
        }
        public void nulpunktsJustering(double værdi)
        {
            beregnetNværdi = NulpunktObjekt.Justering(værdi);
        }
        
    
    }
}