using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    internal class Division : BaseCalculator
    {
        public override double Calculate(double a, double b)
        {
            if (b == 0)
        {
                throw new ArgumentException("No se puede dividir por cero");
    }
            return a / b;
    }
    }
}
