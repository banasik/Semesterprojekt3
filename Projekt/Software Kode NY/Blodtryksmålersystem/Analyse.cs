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
        public double[] diaSystoliskArray;
        private Logik logik;
        private List<double> blodtryksliste;
        int counter;

        public Analyse(Logik logik_)
        {
            //logik = new Logik();
            logik = logik_;
            blodtryksliste = new List<double>();
            counter = 0;
            diaSystoliskArray = new double[1000];
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

        public void DiaSystolisk()
        {
                for (int i = 0; i < logik.UILISTE.Count; i++)
                {
                    diaSystoliskArray[counter] = logik.UILISTE[i];
                    counter++;
                    if (counter > 999)
                    {
                        counter = 0;
                    }
                }
            
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
