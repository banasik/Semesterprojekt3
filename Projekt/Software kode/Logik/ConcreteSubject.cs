using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    class ConcreteSubject : Subject
    {
        private int value;

        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
                Notify(value);
            }
        }
    }
}
