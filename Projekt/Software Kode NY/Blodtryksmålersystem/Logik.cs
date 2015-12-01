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
    public class Logik : ISubject
    {
        private DatabaseAdgang Database = new DatabaseAdgang();
        private IndhentDAQData DAQdata = new IndhentDAQData();
        private Thread updateUI;
        public List<double> uiList;
        private List<IObserver> observers;
        int counter;

        public Logik()
        {
            updateUI = new Thread(() => updateListe());
            //updateUI.Start();
            uiList = new List<double>();
            observers = new List<IObserver>();
            UILISTE = new List<double>();
            counter = 0;
            for (int i = 0; i <799; i++)
            {
                UILISTE.Add(0);
            }
        }

        public void StartTraad()
        {
            updateUI.Start();
        }

        private void updateListe()
        {
            while (isRunningLogik())
            {
                uiList = DAQdata.getList();
                //List<double> xværdier = new List<double>();
               
                //if (uiList.Count > 0)
                //{
                //    for (int i = 0; i < 500; i++)
                //    {
                if (uiList.Count > 0 && counter < 800)
                {
                    UILISTE[counter] = (uiList[uiList.Count-1]);
                    counter++;
                    Notify();
                }
                if (counter == 799)
                {
                    counter = 0;
                }
                    //}
                    //Subject.Value = uiList;
                    //updateChart();
                    //Thread.Sleep(1);                
            }
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

        public void Notify()
        {

            foreach (IObserver obs in observers)
            {
                obs.UpdateChart();
            }
        }

        private void Kalibrering()
        {
            double værdi1;
            double værdi2;
            double værdi3;
            double voltVærdi;

          

        }
    }
}
