using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Aritmetic_operators
{
    internal class ModuleCalculator:Calculable
    {
        public void Calculate()
        {

            Console.WriteLine("Ingrese el primer numero:");
            var a = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Y el segundo:");
            var b = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(Module(a, b));
        }

        public int Module(int a, int b)
        {
            return checked(a % b);
        }

        public double Module(double a, double b)
        {
            return checked(a % b);
        }

        public float Module(float a, float b)
        {
            return checked(a % b);
        }

        public decimal Module(decimal a, decimal b)
        {
            return checked(a % b);
        }
    }
}
