using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    interface Subject
    {
        private List<Observer> observers = new List<Observer>();
        //private ConcreteSubject subject;
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify(int val)
        {
            foreach (var observer in observers)
            {
                observer.Update(val);
                //observers.Add(subject.Value);
            }
        }
    }
}
