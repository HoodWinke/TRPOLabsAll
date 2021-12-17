using core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soldatkin
{
   public class EquationAdapter : IEquation
    {
        private readonly ILinearEquation linearEquation;

        public EquationAdapter(ILinearEquation _linearEquation)
        {
            linearEquation = _linearEquation;
        }

        public double[] Solve(double a, double b, double c = 0)
        {
            return new[] { linearEquation.Solve(a, b) };
        }
    }
}
