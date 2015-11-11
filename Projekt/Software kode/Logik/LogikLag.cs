using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndhentData;
using DatabaseAdgang;
using System.Threading;

namespace Logik
{
    public class LogikLag
    {
        private DBAdgang Database = new DBAdgang();
        private IndhentDataDAQ DAQdata = new IndhentDataDAQ();
        private Thread updateUI; //Tråd til opdatering af user interface
        private List<double> uiList;
        private ConcreteSubject Subjekt;

        public LogikLag()
        {
            updateUI = new Thread(() => updateGUI()); //Benyttes i metoden updateGUI()
            updateUI.Start();
            uiList = new List<double>();
            Subjekt = new ConcreteSubject();
        }

        private void updateGUI()
        {
            while (isRunningLogik())
            {
                uiList = getListLogik(); //Listen med data fra datalag lægges i en ny liste

                if (uiList.Count > 0)
                {
                    Subjekt.Value = uiList
                    updateChart();
                    Thread.Sleep(1); //Sænker tråden 1 ms.
                }
            }
        }

        public bool isRunningLogik()
        {
            return DAQdata.IsRunning();
        }

        public List<double> getListLogik()
        {
            return DAQdata.getList();
        }

        public void indhentDataLogik()
        {
            DAQdata.indhentData();
        }

        public void stopReadDataLogik()
        {
            DAQdata.stopReadData();
        }

        public void gemData(string forsøgsnavn, int autogenereretNR, List<double> samplelist)
        {
            Database.gemData(forsøgsnavn, autogenereretNR, samplelist);
        }
    }
} 
