﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using NationalInstruments.DAQmx;
using System.Collections;
using System.ComponentModel;
using System.Data;
using NationalInstruments;

namespace IndhentData
{
    public class IndhentDataDAQ
    {
        //De fire væsentlige herunder
        private AnalogMultiChannelReader analogInReader;
        private Task myTask;
        private Task runningTask;
        private AsyncCallback analogCallback; //Tråd - Delegate, en event der hele tiden bliver kaldt af sig selv, så der kan arbejdes med tråde

        public AnalogWaveform<double>[] data;
        private DataColumn[] dataColumn = null;
        public DataTable dataTable = null;
        private List<double> dataList;

        public bool IsRunning() //Metode der tjekker om min task er ledig, hvilket den er så længe den ikke er null. 
        { //IsRunning() metoden har til formål at kontrollere hvornår tråden køres
            if (runningTask != null)
            {
                return true;
            }
            else { return false; }
        }
        public IndhentDataDAQ()
        {
            dataTable = new DataTable();
            dataList = new List<double>();
        }

        //Skraldespanden
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        if (components != null)
        //        {
        //            components.Dispose();
        //        }
        //        if (myTask != null)
        //        {
        //            runningTask = null;
        //            myTask.Dispose();
        //        }
        //    }
        //    Dispose(disposing);
        //}

        public void indhentData()
        {
            if (runningTask == null)
            {
                try
                {
                    // Create a new task
                    myTask = new Task();

                    // Create a virtual channel
                    myTask.AIChannels.CreateVoltageChannel("Dev1/ai0", "",
                        (AITerminalConfiguration)(-1), Convert.ToDouble(-3.00),
                        Convert.ToDouble(3.00), AIVoltageUnits.Volts);

                    // Configure the timing parameters
                    myTask.Timing.ConfigureSampleClock("", Convert.ToDouble(1000),
                        SampleClockActiveEdge.Rising, SampleQuantityMode.ContinuousSamples, 1000);

                    // Verify the Task
                    myTask.Control(TaskAction.Verify);

                    // Prepare the table for Data
                    InitializeDataTable(myTask.AIChannels, ref dataTable);

                    runningTask = myTask;
                    analogInReader = new AnalogMultiChannelReader(myTask.Stream);
                    analogCallback = new AsyncCallback(AnalogInCallback); //Håndterer de data vi for ind løbende, selvkørende event

                    // Use SynchronizeCallbacks to specify that the object 
                    // marshals callbacks across threads appropriately.
                    analogInReader.SynchronizeCallbacks = true; //Sørger for at sætte trådene til den prioritet som de skal have
                    analogInReader.BeginReadWaveform(Convert.ToInt32(10),
                        analogCallback, myTask);
                }
                catch (DaqException exception)
                {
                    runningTask = null;
                    myTask.Dispose();
                    throw exception;
                }
            }
        }
        private void AnalogInCallback(IAsyncResult ar) //Asynkron callback
        {
            try
            {
                if (runningTask != null && runningTask == ar.AsyncState)
                {
                    // Read the available data from the channels
                    data = analogInReader.EndReadWaveform(ar);

                    // Plot your data here
                    dataToDataTable(data, ref dataTable);

                    analogInReader.BeginMemoryOptimizedReadWaveform(Convert.ToInt32(10),
                        analogCallback, myTask, data);
                }
            }
            catch (DaqException exception)
            {
                runningTask = null;
                myTask.Dispose();
                throw exception;
            }
        }
        private void dataToDataTable(AnalogWaveform<double>[] sourceArray, ref DataTable dataTable)
        {
            // Iterate over channels
            int currentLineIndex = 0;
            foreach (AnalogWaveform<double> waveform in sourceArray)
            {
                for (int sample = 0; sample < waveform.Samples.Count; ++sample)
                {
                    if (sample == 10)
                        break;

                    //dataTable.Rows[sample][currentLineIndex] = waveform.Samples[sample].Value;
                    //Flytter data fra Waveform-array til dataList:
                    dataList.Add(waveform.Samples[sample].Value);
                }
                currentLineIndex++;
            }
        }

        public List<double> getList()
        {
            return dataList; //Returneres så listen kan tilgåes senere
        }
        public void InitializeDataTable(AIChannelCollection channelCollection, ref DataTable data)
        {
            int numOfChannels = channelCollection.Count;
            data.Rows.Clear();
            data.Columns.Clear();
            dataColumn = new DataColumn[numOfChannels];
            int numOfRows = 10;

            for (int currentChannelIndex = 0; currentChannelIndex < numOfChannels; currentChannelIndex++)
            {
                dataColumn[currentChannelIndex] = new DataColumn();
                dataColumn[currentChannelIndex].DataType = typeof(double);
                dataColumn[currentChannelIndex].ColumnName = channelCollection[currentChannelIndex].PhysicalName;
            }

            data.Columns.AddRange(dataColumn);

            for (int currentDataIndex = 0; currentDataIndex < numOfRows; currentDataIndex++)
            {
                object[] rowArr = new object[numOfChannels];
                data.Rows.Add(rowArr);
            }
        }
        public void stopReadData() //Metoden gør så tråden ikke fortsætter i en evighed, fører til STOP-knap
        {
            if (runningTask != null)
            {
                // Dispose of the task
                runningTask = null;
                myTask.Dispose();
            }
        }
    }
}
