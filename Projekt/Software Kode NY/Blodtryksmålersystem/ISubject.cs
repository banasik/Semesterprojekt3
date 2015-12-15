using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DTO;

namespace DTO
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Notify(List<double> data);
    }
}
