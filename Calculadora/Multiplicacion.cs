using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Multiplicacion:Operacion
    {
        override public double RealizarCalculo(double value1, double value2)
        {
            return value1*value2;
        }
    }
}
