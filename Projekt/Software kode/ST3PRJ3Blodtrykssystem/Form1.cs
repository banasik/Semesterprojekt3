using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Logik;
using IndhentData; //Skal fjernes når Logik er implementeret, fjern også i reference

namespace ST3PRJ3Blodtrykssystem
{
    public partial class Form1 : Form
    {
        private IndhentDataDAQ dt; //Flyttes til Logik
        private LogikLag logik; 
        private LogikLag dtLogik;
        private Thread updateUI; //Tråd til opdatering af user interface
        private List<double> uiList;
        private int AutogenNR; //AutogeneretNR der skal tælles 1 op hver gang der trykkes på GEM-knappen.

        public Form1()
        {
            InitializeComponent();
            dt = new IndhentDataDAQ(); //Flyttes til Logik
            dtLogik = new LogikLag();
            logik = new LogikLag();
            uiList = new List<double>();
            updateUI = new Thread(() => updateGUI()); //Benyttes i metoden updateGUI()
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textForsøgsnavn_TextChanged(object sender, EventArgs e)
        {
            start.Enabled = true;
            start.BackColor = Color.DarkSeaGreen;
        }

        private void updateGUI()
        {
            while (dtLogik.isRunningLogik())
            {
                uiList = dtLogik.getListLogik(); //Listen med data fra datalag lægges i en ny liste

                if (uiList.Count > 0)
                {
                    updateChart();
                    Thread.Sleep(1); //Sænker tråden 1 ms.
                }
            }
        }

        private delegate void UpdateUICallback();

        private void updateChart()
        {
            if (chart1.InvokeRequired)
            {
                UpdateUICallback d = new UpdateUICallback(updateChart);
                this.Invoke(d);
            }
            else
            {
                if (uiList.Count > 2000) //Vises først i chart når listen indeholder mere end 500 samples
                {
                    chart1.Series["Series1"].Points.Clear(); //Charts indeholder kun de 500 sidste samples
                    chart1.Series["Series1"].Points.DataBindY(uiList.GetRange(uiList.Count - 2001, 2000)); //De sidste 500 samples i listen vises i chart
                }
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            dtLogik.indhentDataLogik();

            if (dtLogik.isRunningLogik())
            {
                updateUI.Start();
            }
            gem.Enabled = true;
        }

        private void afslut_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"].Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.stopReadData();
            updateUI.Abort(); //Kaster tråden væk
        }

        private void gem_Click(object sender, EventArgs e)
        {
            AutogenNR++; //Kan det laves på denne måde? NR der skal gemmes med i databasen
            // logiklag.gemData(textForsøgsnavn.Text, AutogenNR, uiList);
            // Indsæt igen når logiklag er implementeret
        }

    }
}
