using core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soldatkin
{
    public class SquareEquation : IEquation
    {
        public double[] Xs { get; set; }

        public double[] Solve(double a, double b, double c)
        {
            Xs = CalculateSquareEquitation(a, b, c);
            return Xs;
        }

        private double[] CalculateSquareEquitation(double a, double b, double c)
        {
            if (a == 0)
                return null;

            double D = Discriminant(a, b, c);

            if (D < 0)
                return Array.Empty<double>();

            if (D == 0)
                return new[] { (-b) / (2 * a) };

            var sqrtDiscriminant = Math.Sqrt(D);
            return new[] { (-b + sqrtDiscriminant) / (2 * a), (-b - sqrtDiscriminant) / (2 * a) };
        }


        protected double Discriminant(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
    }
}
