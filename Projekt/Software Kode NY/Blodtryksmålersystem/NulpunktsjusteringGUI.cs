using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blodtryksmålersystem
{
    public partial class NulpunktsjusteringGUI : Form
    {
        public NulpunktsjusteringGUI()
        {
            InitializeComponent();
        }

        private void JaKnapNul_Click(object sender, EventArgs e)
        {
            var kalibrering = new KalibreringGUI();
            kalibrering.Show();
            this.Hide(); 
        }

        private void NejKnapNul_Click(object sender, EventArgs e)
        {
            var kalibrering = new KalibreringGUI();
            kalibrering.Show();
            this.Hide(); 
        }
    }
}
