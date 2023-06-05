using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Aritmetic_operators
{
    internal class AverageCalculator:Calculable
    {
        public void Calculate()
        {

            Console.WriteLine("Ingrese el primer numero:");
            var a = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("El segundo:");
            var b = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Y el tercero:");
            var c = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(Average(a, b, c));
        }

        public int Average(int a, int b, int c)
        {
            return a + b + c / 3;
        }

        public double Average(double a, double b, double c)
        {
            return a + b + c / 3;
        }

        public float Average(float a, float b, float c)
        {
            return a + b + c / 3;
        }

        public decimal Average(decimal a, decimal b, decimal c)
        {
            return a + b + c / 3;
        }
    }
}
