using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Threading;

namespace LogikLag
{
    public class Logik : Subject
    {
        private DatabaseAdgang Database = new DatabaseAdgang();
        private IndhentDAQData DAQdata = new IndhentDAQData();
        private Thread updateUI;
        private List<double> uiList;
        private double[] array;

        public Logik()
        {
            updateUI = new Thread(() => updateListe());
            updateUI.Start();
            uiList = new List<double>();
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

                if(uiList.Count > 0)
                {
                    for (int i = 0; i < 500; i++)
                    {

                        Notify(array);
                    }
                    //Subject.Value = uiList;
                    //updateChart();
                    Thread.Sleep(1);
                }
            }
        }

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
    }
}
