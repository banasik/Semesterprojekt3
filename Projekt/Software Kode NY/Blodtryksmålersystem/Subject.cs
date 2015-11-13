using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace LogikLag
{
    abstract class Subject
    {
        private List<double> dListe;
        IObserver Iobserver;
        public void Attach(IObserver observer)
        {
            observer = Iobserver;
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.UpdateChart(dListe);
            }
        }
    }
}
