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
    public partial class KalibreringGUI : Form
    {
        public KalibreringGUI()
        {
            InitializeComponent();
        }

        private void JaKnapKali_Click(object sender, EventArgs e)
        {
            var hovedGUI = new HovedGUI();
            hovedGUI.Show();
            this.Hide();
        }

        private void NejKnapKali_Click(object sender, EventArgs e)
        {
            var hovedGUI = new HovedGUI();
            hovedGUI.Show();
            this.Hide();
        }
    }
}
