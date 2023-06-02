namespace Programa_de_círculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*No se maneja la posibilidad de que el usuario ingrese un input incorrecto, creo que eso requeriría
                     * Try y Catch y algún loop, pero como no los vimos lo dejo como está*/


            double radio = 0;
            double resultado;


            Console.WriteLine("Escribe el radio del círculo:");
            radio = Convert.ToDouble(Console.ReadLine());

            resultado = 2 * Math.PI * radio;
            Console.WriteLine("El resultado es " + resultado + ".");
        }
    }
}