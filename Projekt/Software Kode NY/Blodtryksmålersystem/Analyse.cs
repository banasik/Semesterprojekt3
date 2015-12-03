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
            get { return diastole_; }
            set
            {
                if (value > 0)
                {
                    diastole_ = value;
                }
            }
        }
        private double systole_;
        public double Systole_
        {
            get { return systole_; }
            set
            {
                if (value>0)
                {
                    systole_ = value;
                }
            }
        }
        public double[] diaSystoliskArray;
        private Logik logik;

        public Analyse(Logik logik_)
        {
            logik = logik_;
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
            for (int i = 0; i < 250; i++)
            {
                Diastole_ = diastoleListe.Min();
                System.Threading.Thread.Sleep(200);
            }
                //for (int i = 0; i < logik.UILISTE.Count; i++)
                //{
                //    diaSystoliskArray[counter] = logik.UILISTE[i];
                //    counter++;
                //    if (counter > 999)
                //    {
                //        counter = 0;
                //    }
                //}
            
        }
        public void Systole(List<double> systoleListe)
        {
            for (int i = 0; i < 250; i++)
            {
                Systole_ = systoleListe.Min();
                System.Threading.Thread.Sleep(200);
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
