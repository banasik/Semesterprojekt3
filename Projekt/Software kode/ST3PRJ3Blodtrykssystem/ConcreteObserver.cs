using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logik;

namespace ST3PRJ3Blodtrykssystem
{
    class ConcreteObserver : Observer
    {
        private ConcreteSubject subject;
        private static int number = 0;

        public override void Update(int val)
        {
            Console.WriteLine("{0} Subject value is {1}.", val);
        }

        public ConcreteObserver(ConcreteSubject subject)
        {
            subject.Attach(this);
            this.subject = subject;
        }

        ~ConcreteObserver()
        {
            subject.Detach(this);
        }
    }
}
