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
        private List<double> diastoliskListe;
        private List<double> systoliskListe;
        private const double SYS_GRAENSEVAERDI = 2.1;
        private const double DIA_GRAENSEVAERDI = 1.8;
        private Logik logik;
        private List<double> blodtryksliste;
        private List<int> systoleliste;
        int counter;

        public Analyse()
        {
            logik = new Logik();
            blodtryksliste = new List<double>();
            counter = 0;
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

        public double Systolisk()
        {
            double x = 0;
            double y = 0;
            double z = 0;
            // systoliskListe = new List<double>();
            for (int i = 0; i < logik.uiList.Count; i++)
            {
                if (logik.uiList[i] > SYS_GRAENSEVAERDI && logik.uiList[i] > logik.uiList[i + 1])
                {
                    x = i;
                    //systoliskListe.Add(i);
                    i += 50;
                    counter++;
                }
                if (counter > 0 && counter < 6)
                {
                    y += x;
                }
                if (counter == 5)
                {
                    z = y / 5;
                    counter = 0;
                }
                if (systoliskListe.Count > 0 && counter < 6)
                {
                    x = systoliskListe.Average();
                    counter++;
                }
                if (counter == 5)
                {
                    counter = 0;
                }
            }
            return counter;
        }
        public void Diastolisk()
        {
            diastoliskListe = new List<double>();
            for (int i = 0; i < logik.UILISTE.Count; i++)
            {
                if (logik.UILISTE[i] < DIA_GRAENSEVAERDI && logik.UILISTE[i] < logik.UILISTE[i+1])
                {
                    diastoliskListe.Add(i);
                    i += 50;
                }
            }
        }
        public void Puls()
        {

        }

    }
}
