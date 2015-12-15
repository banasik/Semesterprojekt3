using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace LogikLag
{
    public class Analyse
    {
        public double Diastole_ { get; set; }
        public double Systole_ { get; set; }
        public Analyse()
        {
        }
        public void Diastole(List<double> diastoleListe)
        {
            Diastole_ = diastoleListe.Min();
        }
        public void Systole(List<double> systoleListe)
        {
            Systole_ = systoleListe.Max();
        }        
        public void Puls()
        {
        }
    }
}
