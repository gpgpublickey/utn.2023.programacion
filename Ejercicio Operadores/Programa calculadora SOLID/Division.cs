using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_calculadora_SOLID
{
    internal class Division : ICalculable
    {

        public double Calcular(double n1, double n2)
        {
            
          return n1 / n2;
        }
    }
}
