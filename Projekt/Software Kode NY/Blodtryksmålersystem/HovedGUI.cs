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
    public partial class HovedGUI : Form
    {
        //private IndhentDataDAQ dt; //Flyttes til Logik
        //private LogikLag logik; 
        //private LogikLag dt;
        //private Thread updateUI; //Tråd til opdatering af user interface
        //private List<double> uiList;
        private Logik logik;
        private int AutogenNR; //AutogeneretNR der skal tælles 1 op hver gang der trykkes på GEM-knappen.

        public HovedGUI()
        {
            InitializeComponent();
            logik = new Logik();
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
            if (Chart.InvokeRequired)
            {
                UpdateUICallback d = new UpdateUICallback(updateChart);
                this.Invoke(d);
            }
            else
            {
                if (uiList.Count > 500) //Vises først i chart når listen indeholder mere end 500 samples
                {
                    Chart.Series["Series1"].Points.Clear(); //Charts indeholder kun de 500 sidste samples
                    Chart.Series["Series1"].Points.DataBindY(uiList.GetRange(uiList.Count - 501, 500)); //De sidste 500 samples i listen vises i chart
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

    }
}
