///// Solo pide como Input dos numeros, muestra los resultados para todas las operaciones para esos dos valores.

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOperacion suma = new Suma();
            IOperacion resta = new Resta();
            IOperacion multiplicacion = new Multiplicacion();
            IOperacion division = new Division();
            IOperacion modulo = new Modulo();
            IOperacion potencia = new Potencia();

            Calculadora calculadora = new Calculadora(suma, resta, multiplicacion, division, modulo, potencia);
            Console.WriteLine("Ingrese Valor1:");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese Valor2:");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double resultadoSuma = calculadora.Sumar(numero1, numero2);
            double resultadoResta = calculadora.Restar(numero1, numero2);
            double resultadoMultiplicacion = calculadora.Multiplicar(numero1, numero2);
            double resultadoDivision = calculadora.Dividir(numero1, numero2);
            double resultadoModulo = calculadora.CalcularModulo(numero1, numero2);
            double resultadoPotencia = calculadora.CalcularPotencia(numero1, numero2);

            Console.WriteLine($"Suma: {resultadoSuma}");
            Console.WriteLine($"Resta: {resultadoResta}");
            Console.WriteLine($"Multiplicación: {resultadoMultiplicacion}");
            Console.WriteLine($"División: {resultadoDivision}");
            Console.WriteLine($"Modulo: {resultadoModulo}");
            Console.WriteLine($"Potencia: {resultadoPotencia}");

            Console.ReadLine();
        }
    }
}