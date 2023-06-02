using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_calculadora_SOLID
{
    internal class Calculo
    {

        public double Calcular(ICalculable operacion, double n1, double n2)
        {

            double res = operacion.Calcular(n1, n2);
            return res;
        }
    }
}
