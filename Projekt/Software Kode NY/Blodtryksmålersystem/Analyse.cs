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
        private double diastole_;
        public double Diastole_
        {
            get;
            set;

        }
        private double systole_;
        public double Systole_
        {
            get; set;
            
        }
        //public double[] diaSystoliskArray;
        private Logik logik;

        public Analyse()
        {
            //logik = logik_;
            //logik = new Logik();
        }

        //public List<int> BeregnSystole(List<int> systoleliste_)
        //{
        //    blodtryksliste = logik.UILISTE;

        //    systoleliste = new List<int>();
        //    for (int i = 0; i < blodtryksliste.Count; i++)
        //    {
        //        if (blodtryksliste[i] > SYS_GRAENSEVAERDI && blodtryksliste[i] > blodtryksliste[i + 1])
        //        {
        //            systoleliste.Add(i);
        //            i += 50;
        //        }
        //        systoleliste_ = systoleliste;
        //    }
        //    return systoleliste_;
        //}

        public void Diastole(List<double> diastoleListe)
        {
            
                Diastole_ = diastoleListe.Min();
            
        }
        public void Systole(List<double> systoleListe)
        {
            
                Systole_ = systoleListe.Max();
            
        }
        //public void Diastolisk()
        //{
        //    diaSystoliskListe = new List<double>();
        //    for (int i = 0; i < logik.uiList.Count; i++)
        //    {
        //        if (logik.uiList[i] < DIA_GRAENSEVAERDI && logik.uiList[i] < logik.uiList[i+1])
        //        {
        //            diaSystoliskListe.Add(i);
        //            i += 5;
        //        }
        //    }
        //}
        public void Puls()
        {

        }

    }
}
