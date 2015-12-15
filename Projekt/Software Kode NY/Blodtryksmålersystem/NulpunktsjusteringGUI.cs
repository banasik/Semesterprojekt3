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

namespace Blodtryksmålersystem
{
    public partial class NulpunktsjusteringGUI : Form
    {
        private Logik logik;
        public NulpunktsjusteringGUI()
        {
            InitializeComponent();
            logik = new Logik();
        }

        private void ForetagNulKnap_Click(object sender, EventArgs e)
        {
            logik.StartNulPunkt();
            var hovedgui = new HovedGUI(logik);
            hovedgui.Show();
            this.Hide();
        }
    }
}
