﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndhentData;
using DatabaseAdgang;

namespace Logik
{
    public class LogikLag
    {
        private DBAdgang Database = new DBAdgang();
        private IndhentDataDAQ DAQdata = new IndhentDataDAQ();

        public void isRunningLogik()
        {
            DAQdata.IsRunning();
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
        }

        public void gemData(string forsøgsnavn, int autogenereretNR, List<double> samplelist)
        {
            Database.gemData(forsøgsnavn, autogenereretNR, samplelist);
        }
    }
}