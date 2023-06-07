using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public interface IOperacion
    {
        public double RealizarCalculo(double value1, double value2);
    }
}
