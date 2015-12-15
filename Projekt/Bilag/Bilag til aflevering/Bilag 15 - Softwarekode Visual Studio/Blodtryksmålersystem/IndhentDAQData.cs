using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.ComponentModel;
using NationalInstruments.DAQmx;
using NationalInstruments;
using System.Data;
using System.Collections;
using DTO;

namespace Data
{
    public class IndhentDAQData:ISubject
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
        private List<IObserver> observers;

        public bool IsRunning() //Metode der tjekker om min task er ledig, hvilket den er så længe den ikke er null. 
        { //IsRunning() metoden har til formål at kontrollere hvornår tråden køres
            if (runningTask != null)
            {
                return true;
            }
            else { return false; }
        }
        public IndhentDAQData()
        {
            dataTable = new DataTable();
            dataList = new List<double>();
            observers = new List<IObserver>();
        }
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
                    // Her bliver samplerate sat til 1000 samt samples per channel til 20
                    myTask.Timing.ConfigureSampleClock("", Convert.ToDouble(1000),
                        SampleClockActiveEdge.Rising, SampleQuantityMode.ContinuousSamples,10);

                    // Verify the Task
                    myTask.Control(TaskAction.Verify);

                    // Prepare the table for Data
                    InitializeDataTable(myTask.AIChannels, ref dataTable);

                    runningTask = myTask;
                    analogInReader = new AnalogMultiChannelReader(myTask.Stream);
                    analogCallback = new AsyncCallback(AnalogInCallback); //Håndterer de data vi får ind løbende, selvkørende event

                    // Use SynchronizeCallbacks to specify that the object 
                    // marshals callbacks across threads appropriately.
                    analogInReader.SynchronizeCallbacks = true; //Sørger for at sætte trådene til den prioritet som de skal have
                    analogInReader.BeginReadWaveform(Convert.ToInt32(20),
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
        // Denne metode kalder dataToDataTable og sender data og en reference med som parameter.
        // Samt sker der asynkron callback, hvis DAQ'en kører.
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

                    analogInReader.BeginMemoryOptimizedReadWaveform(Convert.ToInt32(20),
                        analogCallback, myTask, data);
                }
            }
            catch (DaqException exception)
            {
                runningTask = null;
                myTask.Dispose();
                //throw exception;
            }
        }
        // Denne metode tilføjer alle samples i sourceArray over i råData og kalder Notify der "skubber" sampleværdierne op til Logik laget.
        private void dataToDataTable(AnalogWaveform<double>[] sourceArray, ref DataTable dataTable)
        {
            // Iterate over channels
            int currentLineIndex = 0;
            List<double> råData = new List<double>();

            foreach (AnalogWaveform<double> waveform in sourceArray)
            {
                for (int sample = 0; sample < waveform.Samples.Count; ++sample)
                {
                    råData.Add(waveform.Samples[sample].Value);
                }
                
                Notify(råData);

                currentLineIndex++;
            }
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
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }
        //Her bruges der en "Push-Notify", som skubber en liste op til logiklaget. 
        public void Notify(List<double> graf)
        {
            foreach (IObserver obs in observers)
            {
                obs.Gennemsnit(graf);
            }
        }
    }
}
