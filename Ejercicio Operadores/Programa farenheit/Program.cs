namespace Programa_farenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*No se maneja la posibilidad de que el usuario ingrese un input incorrecto, creo que eso requeriría
                     * Try y Catch y algún loop, pero como no los vimos lo dejo como está*/


            double celsius = 0;
            double resultado;


            Console.WriteLine("Escribe los grados celsius:");
            celsius = Convert.ToDouble(Console.ReadLine());


            resultado = celsius * 9 / 5 + 32;
            Console.WriteLine("El resultado es " + resultado + ".");
        }
    }
}