using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Execution
{
    public class AircraftDesign
    {
        public void Power(double d, double v, out double p)
        {
            p = d * d * v * v * v / 2000;
        }
        public void Cost(double p, double d, out double c)
        {
            c = p * d;
        }
        public void Life(double p, double d, out double l)
        {
            l = 100 / Math.Exp(Math.Sqrt((p + d / 10) / 100));
        }

        public void AddNumbers(double x1, double x2, out double y1)
        {
            y1 = x1 + x2;
        }

        public void MultiplyNumbers(double x1, double x2, out double y1)
        {
            y1 = x1 * x2;
        }
    }
}
