namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            var sumInt = HelperCalculator.Addition(3, 4);
            var sumDecimal = HelperCalculator.Addition((decimal)3.53, (decimal)4.72);

            Console.WriteLine("Ejercicio 1:");
            Console.WriteLine(sumInt.ToString() + " SumINT");
            Console.WriteLine(sumDecimal.ToString() + " SumDecimal \n");

            //Ejercicio 2
            var subtractionInt = HelperCalculator.Subtraction(10, 18);
            var subtractionDecimal = HelperCalculator.Subtraction((decimal)8.53, (decimal)1.72);

            Console.WriteLine("Ejercicio 2:");
            Console.WriteLine(subtractionInt.ToString() + " subtractionInt");
            Console.WriteLine(subtractionDecimal.ToString() + " subtractionDecimal \n");


            //Ejercicio 3
            var multiplyNum = HelperCalculator.Multiply((decimal)8, (decimal)1.72);

            Console.WriteLine("Ejercicio 3:");
            Console.WriteLine(multiplyNum.ToString() + " multiplyNum \n");


            //Ejercicio 4
            var divideNum = HelperCalculator.Divide(15, 6);
            var divideNum2 = HelperCalculator.Divide((decimal)17, (decimal)6);

            Console.WriteLine("Ejercicio 4:");
            Console.WriteLine(divideNum.ToString() + " divideNum ");
            Console.WriteLine(divideNum2.ToString() + " divideNum2 \n");

            //Ejercicio 5
            var moduleNum = HelperCalculator.Module((decimal)56, (decimal)6.56);

            Console.WriteLine("Ejercicio 5:");
            Console.WriteLine(moduleNum.ToString() + " moduleNum \n");

            //Ejercicio 6
            var elevateNum = HelperCalculator.Elevate(3, 3);

            Console.WriteLine("Ejercicio 6:");
            Console.WriteLine(elevateNum.ToString() + " elevateNum \n");

            //Ejercicio 7
            var promNum = HelperCalculator.Prom(3, 3, 4);

            Console.WriteLine("Ejercicio 7:");
            Console.WriteLine(promNum.ToString() + " promNum \n");

            //Ejercicio 8
            Ejercicio8();

            //Ejercicio 9
            Ejercicio9();

            //Ejercicio 10
            Ejercicio10();
            //Console.ReadLine();
        }

        private static void Ejercicio8()
        {
            Console.WriteLine("Ejercicio 8:");
            Console.WriteLine("Ingrese la base: ");
            string _base = Console.ReadLine();
            Console.WriteLine("Ingrese la altura: ");
            string height = Console.ReadLine();

            if (HelperCalculator.VerifyInput(_base) && HelperCalculator.VerifyInput(height))
            {
                var area = HelperCalculator.Area(Convert.ToDecimal(_base), Convert.ToDecimal(height));
                Console.WriteLine(area.ToString() + " area del triangulo \n");
            }
            else
            {
                Console.WriteLine("Base o altura ingresados no son validos! \n");
            }
        }

        private static void Ejercicio9()
        {
            Console.WriteLine("Ejercicio 9:");
            Console.WriteLine("Ingrese el radio: ");
            string radio = Console.ReadLine();

            if (HelperCalculator.VerifyInput(radio))
            {
                var area = HelperCalculator.AreaRadio(Convert.ToDecimal(radio));
                Console.WriteLine(area.ToString() + " area del circulo \n");
            }
            else
            {
                Console.WriteLine("El radio ingresado no es valido! \n");
            }
        }

        private static void Ejercicio10()
        {
            Console.WriteLine("Ejercicio 10:");
            Console.WriteLine("Ingrese la temperatura: ");
            string temperature = Console.ReadLine();

            if (HelperCalculator.VerifyInput(temperature))
            {
                var tempF = HelperCalculator.ConvertToFarenheit(Convert.ToDecimal(temperature));
                Console.WriteLine(tempF.ToString() + " F \n");
            }
            else
            {
                Console.WriteLine("la temperatura ingresada no es valida! \n");
            }
        }
    }
}