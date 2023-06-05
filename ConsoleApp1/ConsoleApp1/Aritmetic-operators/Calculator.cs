using ConsoleApp1.Operadores_aritmeticos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Aritmetic_operators
{
    internal class Calculator
    {
        public void Calculate() {


            

        }

        public static void Sum() {
            SumCalculate calculate = new SumCalculate();

            Console.WriteLine("Ingrese el primer numero:");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Y el segundo:");
            var b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(calculate.Calculate(a, b));
        }

        public static void Rest()
        {
            RestCalculate calculate = new RestCalculate();

            Console.WriteLine("Ingrese el primer numero:");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Y el segundo:");
            var b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(calculate.Calculate(a, b));
        }


    }
}
