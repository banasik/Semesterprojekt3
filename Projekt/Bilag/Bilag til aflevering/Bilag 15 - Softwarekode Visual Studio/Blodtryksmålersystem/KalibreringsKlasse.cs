using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LogikLag
{
    class Kalibrering
    {
        public Kalibrering()
        {
        }
        public double Kalibrer()
        {
            double kalibreringsVærdi = Convert.ToDouble(ConfigurationManager.AppSettings["KalibreringsKoefficient"]);
            return kalibreringsVærdi;
        }
    }
}
