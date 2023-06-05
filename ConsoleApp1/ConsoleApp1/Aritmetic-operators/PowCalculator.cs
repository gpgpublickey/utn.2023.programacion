using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Aritmetic_operators
{
    internal class PowCalculator:Calculable
    {

        public void Calculate()
        {

            Console.WriteLine("Ingrese el primer numero:");
            var a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Y el segundo:");
            var b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Pow(a, b));
        }
        public double Pow(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
