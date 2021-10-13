using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrpoLaba1
{
    class A
    {
        public double X {get; set;}
        public double Solve(double a, double b)
        {
            if (a == 0)
                return null;

            X = -b / a;
            return X;
        }
    }
}
