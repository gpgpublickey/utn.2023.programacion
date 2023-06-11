using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Potencia:Operacion
    {
        override public double RealizarCalculo(double value1, double value2)
        {
            return Math.Pow(value1, value2);
        }
    }
}
