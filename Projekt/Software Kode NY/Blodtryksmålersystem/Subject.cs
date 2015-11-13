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
            Iobserver = observer;
        }

        public void Notify(double[] array)
        {
            Iobserver.setArray(array);
            Iobserver.UpdateChart();
        }
    }
}
