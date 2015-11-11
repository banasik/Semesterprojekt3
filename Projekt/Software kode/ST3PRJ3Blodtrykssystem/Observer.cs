using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logik;

namespace ST3PRJ3Blodtrykssystem
{
    interface Observer
    {
        abstract public void Update(int val);
    }
}
