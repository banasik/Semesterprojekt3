using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    interface IObserver
    {
        abstract public void UpdateChart(int val);
    }
}
