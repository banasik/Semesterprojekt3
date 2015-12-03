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
using System.Timers;

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
        private double[] DiaSysArray;
        private List<double> guiliste;
        private Analyse diaSystole;

        public HovedGUI()
        {
            InitializeComponent();
            logik = new Logik();
            diaSystole = new Analyse(logik);
            //GUIArray = new double[500];
            logik.Attach(this);
           // dt = new IndhentDataDAQ(); //Flyttes til Logik
            //logik = new Logiklag();
            //dt = new LogikLag();
            //uiList = new List<double>();
            //updateUI = new Thread(() => updateGUI()); //Benyttes i metoden updateGUI()
        }
        private void textForsøgsnavn_TextChanged(object sender, EventArgs e)
        {
            StartKnap.Enabled = true;
            StartKnap.BackColor = Color.DarkSeaGreen;
        }

        private delegate void UpdateUICallback();
        private void updateChart()
        {
            guiliste = logik.UILISTE;
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
                    //textSys.Text = Convert.ToString(Convert.ToInt16(logik.getSys()));
                    //textDia.Text = Convert.ToString(Convert.ToInt16(logik.getDia()));
                    textSys.Text = Convert.ToString(Convert.ToInt16(diaSystole.Systole_));
                    textDia.Text = Convert.ToString(Convert.ToInt16(diaSystole.Diastole_));
                    
                    //UpdateSys();
                }
            }
        }
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

        public void UpdateChart()
        {
            updateChart();
        }

        //private void UpdateSys()
        //{
        //    textSys.Text = Convert.ToString(systole.Systolisk());
        //}
        private void textSys_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
