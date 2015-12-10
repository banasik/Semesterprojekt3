using System;
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
        private Logik logik;
        private int AutogenNR; //AutogeneretNR der skal tælles 1 op hver gang der trykkes på GEM-knappen.
        private List<double> guiliste;
        private Analyse diaSystole;
        private System.Timers.Timer myTimer;
        private string Forsøgsnavn;

        public HovedGUI()
        {
            InitializeComponent();
            logik = new Logik();
            diaSystole = new Analyse();
            logik.Attach(this);
            myTimer = new System.Timers.Timer();
            myTimer.Enabled = true;
            myTimer.Interval = 3000;
            myTimer.Elapsed += myTimer_Elapsed;
            logik.Attach(this);
            //GUISetNVærdi();

        }

        void myTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            MethodInvoker action = delegate
            { textDia.Text = Convert.ToInt32(logik.DiastoleVærdi).ToString();
            textSys.Text = Convert.ToInt32(logik.SystoleVærdi).ToString();
            };
            
            textDia.BeginInvoke(action);
            textSys.BeginInvoke(action);
        }

        //private void GUISetNVærdi()
        //{
        //    //double værdi = -2;
        //    logik.nulpunktsJustering(værdi);
        //}

        private void textForsøgsnavn_TextChanged(object sender, EventArgs e)
        {
            StartKnap.Enabled = true;
            StartKnap.BackColor = Color.DarkSeaGreen;

            Forsøgsnavn = Convert.ToString(textForsøgsnavn.Text);
        }

        private delegate void UpdateUICallback();
        private void updateChart()
        {
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
            //logik.stopReadDataLogik();
            //myTimer.Close();
           int id =  logik.gemData(Forsøgsnavn);

            //int id; 
            
            textFilnavn.Text = Forsøgsnavn + '_' + Convert.ToString(id); 
        }

        private void AfslutKnap_Click(object sender, EventArgs e)
        {
            logik.stopReadDataLogik();
            myTimer.Close();
            //Application.OpenForms["HovedGUI"].Close();
        }

        private void GemKnap_Click(object sender, EventArgs e)
        {
            //logik.gemData(Forsøgsnavn);
            logik.ClearData(); 
        }

        public void Gennemsnit(List<double> graf)
        {
            guiliste = graf;
            
            updateChart();
        }


        private void GUIFiltrering()
        {
        }

        private void filtreret_CheckedChanged(object sender, EventArgs e)
        {
            if (filtreret.Checked)
            {
                logik.RadioProp = false;
            }
            else if (filtreret.Checked != true)
            {
                logik.RadioProp = true;
            }
        }


    }
}
