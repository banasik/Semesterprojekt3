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
        private Thread update20;
        public List<double> uiList;
        private List<IObserver> observers;
        int counter;
        public double diastoleVærdi;
        public double systoleVærdi;
        private Analyse AnalyseKlasse = new Analyse();
        public List<double> GennemsnitListe;

        public Logik()
        {
            updateUI = new Thread(() => updateListe());
            updateDia = new Thread(() => getDia());
            updateSys = new Thread(() => getSys());
            //updateUI.Start();
            uiList = new List<double>();
            UILISTE = new List<double>();
            GennemsnitListe = new List<double>();
            observers = new List<IObserver>();
            List<double> ListAfTal = new List<double>();
            DAQdata.Attach(this);

            diastoleVærdi = new double();
            systoleVærdi = new double();
            for (int i = 0; i < 799; i++)
            {
                UILISTE.Add(0);
            }
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
                //uiList = DAQdata.getList();
                //    counter = 0;
                //    //double sum = 0.0;
                //    if (uiList.Count > 0 && counter < 21)
                //    {
                //        GennemsnitListe[counter] = (uiList[uiList.Count - 1]);
                //        counter++;
                //    }
                //    if (counter == 20)
                //    {
                //        GennemsnitListe.Average();
                //        counter = 0;
                //    }
                int counter1 = 0;
                //List<double> xværdier = new List<double>();

                //if (uiList.Count > 0)
                //{
                //    for (int i = 0; i < 500; i++)
                //    {
                if (GennemsnitListe.Count > 0 && counter1 < 800)
                {
                    UILISTE[counter1] = (GennemsnitListe[GennemsnitListe.Count - 1]);
                    counter1++;
                    Notify(UILISTE);
                }

                if (counter1 == 799)
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
    }
}