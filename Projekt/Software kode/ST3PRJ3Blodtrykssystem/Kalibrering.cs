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
    public partial class Kalibrering : Form
    {
        public Kalibrering()
        {
            InitializeComponent();
        }

        private void JAkali_Click(object sender, EventArgs e)
        {
            var hovedside = new Form1();
            hovedside.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var hovedside = new Form1();
            hovedside.Show();
            this.Hide();
        }
    }
}
