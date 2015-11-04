using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST3PRJ3Blodtrykssystem
{
    public partial class Nulpunktsjustering : Form
    {
       // private Kalibrering kalibrering;  

        public Nulpunktsjustering()
        {
            InitializeComponent();
        }

        private void JAnul_Click(object sender, EventArgs e)
        {
            var kalibrering = new Kalibrering(); 
            kalibrering.Show();
            this.Hide(); 
            //Application.OpenForms["Form1"].Close();
        }

        private void NEJnul_Click(object sender, EventArgs e)
        {
            var kalibrering = new Kalibrering();
            kalibrering.Show();
            this.Hide(); 
        }
    }
}
