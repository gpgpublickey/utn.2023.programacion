using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    internal class BaseCalculator : ICalculator
    {
        public abstract double Calculate(double a, double b);
    }
}
