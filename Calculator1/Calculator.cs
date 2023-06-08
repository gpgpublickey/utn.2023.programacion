using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    internal class Calculator
    {
        
    private Dictionary<char, ICalculator> operations;

        public Calculator()
        {
            operations = new Dictionary<char, ICalculator>();
        }

        public void RegisterOperation(char operatorSymbol, ICalculator operation)
        {
            operations[operatorSymbol] = operation;
        }

        public double Calcular(char operatorSymbol, double a, double b)
        {
            if (!operations.ContainsKey(operatorSymbol))
            {
                throw new ArgumentException("Operación no válida");
            }
            return operations[operatorSymbol].Calcular(a, b);
        }
    }
}

