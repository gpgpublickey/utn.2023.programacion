using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class HelperCalculator
    {
        internal static int Addition(int n1, int n2)
        {
            return n1 + n2;
        }

        internal static decimal Addition(decimal n1, decimal n2)
        {
            return n1 + n2;
        }

        internal static int Subtraction(int n1, int n2)
        {
            return n1 - n2;
        }

        internal static decimal Subtraction(decimal n1, decimal n2)
        {
            return n1 - n2;
        }

        internal static decimal Multiply(int n1, int n2)
        {
            return n1 * n2;
        }

        internal static decimal Multiply(decimal n1, decimal n2)
        {
            return n1 * n2;
        }

        internal static decimal Divide(int n1, int n2)
        {
            return n1 / n2;
        }

        internal static decimal Divide(decimal n1, decimal n2)
        {
            return n1 / n2;
        }

        internal static decimal Module(int n1, int n2)
        {
            return n1 % n2;
        }

        internal static decimal Module(decimal n1, decimal n2)
        {
            return n1 % n2;
        }

        internal static decimal Elevate(decimal n1, int potencia)
        {
            decimal aux = n1;

            for (int i = 1; i < potencia; i++)
            {
                n1 = n1 * aux;
            }

            return n1;
        }

        internal static decimal Prom(decimal n1, decimal n2, decimal n3)
        {
            return (n1 + n2 + n3) / 3;
        }

        internal static decimal Area(decimal _base, decimal altura)
        {
            return (_base * altura) / 2;
        }

        internal static decimal AreaRadio(decimal radio)
        {
            return 2 * Convert.ToDecimal(Math.PI) * radio;
        }

        internal static decimal ConvertToFarenheit(decimal temperature)
        {
            return ((temperature * 9) / 5) + 32;
        }

        internal static bool VerifyInput(string? value)
        {
            int outputInt;
            decimal outputDecimal;

            if (!string.IsNullOrWhiteSpace(value))
            {
                if (int.TryParse(value, out outputInt))
                {
                    return true;
                }
                else if (decimal.TryParse(value, out outputDecimal))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
