using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikLag
{
    class Filter
    {
        private const int AVG_LENGTH = 5;
        public Filter()
        {
        }
        public List<double> Filtrering(List<double> data)
        {
            double sum = 0;
            List<double> avgPoints = new List<double>();
            for (int i = 0; i < data.Count()- AVG_LENGTH + 1; i++)
            {
                int innerLoopCounter = 0;
                int index = i;
                while (innerLoopCounter < AVG_LENGTH)
                {
                    sum = sum + data[index];
                    innerLoopCounter += 1;
                    index += 1;
                }
                avgPoints.Add(sum / AVG_LENGTH);
                sum = 0;
            }
            return avgPoints;
        }
    }
}
