﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    public interface IEquation
    {
        double[] Solve(double a, double b, double c);
    }
}
