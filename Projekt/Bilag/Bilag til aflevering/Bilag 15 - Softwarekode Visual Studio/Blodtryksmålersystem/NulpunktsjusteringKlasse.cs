using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blodtryksmålersystem;

namespace LogikLag
{
    class Nulpunktsjustering
    {
        private double n;
        public Nulpunktsjustering()
        {

        }
        public double Justering( double justeringværdi)
        {
          n = 0 - (justeringværdi);
            return n;
        }
    }
}
