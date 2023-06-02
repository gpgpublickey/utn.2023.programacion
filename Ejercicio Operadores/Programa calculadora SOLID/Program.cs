using System.Threading.Channels;

namespace Programa_calculadora_SOLID
{
    internal class Program
    {
        public static ICalculable operacion = null;
        public static int seleccion;
        static void Main(string[] args)
        {
            Calculo calculadora = new Calculo();

            double numero1;
            double numero2;
            double resultado;
            bool salir= false;

            while (salir == false)
            {

                Menú();

                numero1 = PrimerNumero();

                numero2 = SegundoNumero();

                resultado = calculadora.Calcular(operacion, numero1, numero2);

                Console.WriteLine("El resultado es " + resultado);

                Console.WriteLine(" ");

                Console.WriteLine("Presiona cualquier tecla para repetir o S para Salir.");

                string opcion = null;

                opcion = Console.ReadLine();
                if (opcion.ToLower() == "s")
                    salir = true;
            }
        }

        private static void Menú()
        {
            seleccion = 0;

            Console.BackgroundColor = ConsoleColor.DarkGreen;

            while (seleccion < 1 || seleccion > 4)
            {
                Console.WriteLine("Qué operación querés hacer?");
                Console.WriteLine("1. Suma.");
                Console.WriteLine("2. Resta.");
                Console.WriteLine("3. Multiplicación.");
                Console.WriteLine("4. División.");
                Console.WriteLine(" ");

                try
                {
                    seleccion = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine(" ");

                }
                catch
                {
                    Console.WriteLine(" ");
                    seleccion = 0;

                }

                if (seleccion < 1 || seleccion > 4)
                {
                    InputIncorrecto();
                }
            }

            switch (seleccion)
            {
                case 1:
                    operacion = new Suma();
                    break;
                case 2:
                    operacion = new Resta();
                    break;
                case 3:
                    operacion = new Multiplicacion();
                    break;
                case 4:
                    operacion = new Division();
                    break;
                default:
                    Console.WriteLine("Error en el switch.");
                    break;
            }
        }

        private static double PrimerNumero()
        {
            seleccion = 0;
            double num1 = 0;

            do
            {
                Console.WriteLine("Ingresá el primer número: ");

                try
                {
                    num1 = Convert.ToDouble(Console.ReadLine());
                    seleccion = 1;
                }
                catch
                {
                    InputIncorrecto();
                }

            } while (seleccion == 0);

            return num1;
        }

        private static double SegundoNumero() 
        {
            double num2 = 0;

            do
            {
                Console.WriteLine("Ingresá el segundo número: ");

                try
                {
                    num2 = Convert.ToDouble(Console.ReadLine());
                    seleccion = 1;
                }
                catch
                {
                    
                    InputIncorrecto();
                    seleccion = 0;
                }

                if (operacion is Division && num2 == 0)
                {
                    seleccion = 0;
                    Console.WriteLine("El divisor no puede ser = 0.");
                    Console.WriteLine("  ");
                }

            } while (seleccion == 0);
                
            return num2;
        }
        private static void InputIncorrecto()
        {
            seleccion = 0;

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Input incorrecto.");
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
        }
    }
}