﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogikLag;
using DTO;

namespace Blodtryksmålersystem
{
    public partial class HovedGUI : Form, IObserver
    {
        //private IndhentDataDAQ dt; //Flyttes til Logik
        //private LogikLag logik; 
        //private LogikLag dt;
        //private Thread updateUI; //Tråd til opdatering af user interface
        //private List<double> uiList;
        private Logik logik;
        private int AutogenNR; //AutogeneretNR der skal tælles 1 op hver gang der trykkes på GEM-knappen.
        //private double[] DiaSysArray;
        private List<double> guiliste;
        private Analyse diaSystole;
        private System.Timers.Timer myTimer;

        public HovedGUI()
        {
            InitializeComponent();
            logik = new Logik();
            diaSystole = new Analyse();
            //GUIArray = new double[500];
            logik.Attach(this);
           // dt = new IndhentDataDAQ(); //Flyttes til Logik
            //logik = new Logiklag();
            //dt = new LogikLag();
            //uiList = new List<double>();
            //updateUI = new Thread(() => updateGUI()); //Benyttes i metoden updateGUI()
            myTimer = new System.Timers.Timer();
            myTimer.Enabled = true;
            myTimer.Interval = 3000;
            myTimer.Elapsed += myTimer_Elapsed;
            logik.Attach(this);
            GUISetNVærdi();

        }

        void myTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            MethodInvoker action = delegate
            { textDia.Text = Convert.ToInt32(logik.diastoleVærdi).ToString();
            textSys.Text = Convert.ToInt32(logik.systoleVærdi).ToString();
            };
            
            textDia.BeginInvoke(action);
            textSys.BeginInvoke(action);
        }

        private void GUISetNVærdi()
        {
            double værdi = -2;
            logik.nulpunktsJustering(værdi);
        }

        private void textForsøgsnavn_TextChanged(object sender, EventArgs e)
        {
            StartKnap.Enabled = true;
            StartKnap.BackColor = Color.DarkSeaGreen;
        }

        private delegate void UpdateUICallback();
        private void updateChart()
        {
            //guiliste = logik.UILISTE;
            if (this.InvokeRequired)
            {
                UpdateUICallback d = new UpdateUICallback(updateChart);
                this.Invoke(d);
            }
            else
            {
                //if (uiList.Count > 500) //Vises først i chart når listen indeholder mere end 500 samples
                {
                    Chart.Series["Series1"].Points.DataBindY(guiliste); //De sidste 500 samples i listen vises i chart
                    logik.getDia();
                    logik.getSys();
                    
                }
            }
        }
        //logik.FiltreringLogik(guiliste) skal ændres, sådan at det kun er guiliste der sendes op.
        private void StartKnap_Click(object sender, EventArgs e)
        {
            logik.indhentDataLogik();

            if (logik.isRunningLogik())
            {
                logik.StartTraad();
            }
            GemKnap.Enabled = true;
        }

        private void StopKnap_Click(object sender, EventArgs e)
        {
            logik.stopReadDataLogik();
            //updateUI.Abort(); //Kaster tråden væk
            myTimer.Close();
        }

        private void AfslutKnap_Click(object sender, EventArgs e)
        {
            Application.OpenForms["HovedGUI"].Close();
        }

        private void GemKnap_Click(object sender, EventArgs e)
        {
            AutogenNR++; //Kan det laves på denne måde? NR der skal gemmes med i databasen
            // logiklag.gemData(textForsøgsnavn.Text, AutogenNR, uiList);
            // Indsæt igen når logiklag er implementeret
        }

        public void Gennemsnit(List<double> graf)
        {
            guiliste = graf;
            
            updateChart();
        }

        //private void UpdateSys()
        //{
        //    textSys.Text = Convert.ToString(systole.Systolisk());
        //}
        private void textSys_TextChanged(object sender, EventArgs e)
        {

        }
        private void GUIFiltrering()
        {
        }

        private void filtreret_CheckedChanged(object sender, EventArgs e)
        {
            if (filtreret.Checked)
            {
                logik.RadioProp = true;
            }
            else if (filtreret.Checked != true)
            {
                logik.RadioProp = false;
            }
        }
    }
}
