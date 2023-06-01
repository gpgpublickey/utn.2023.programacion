internal class Program
{
    private static void Main(string[] args)
    {
        /*No se maneja la posibilidad de que el usuario ingrese un input incorrecto, creo que eso requeriría
                 * Try y Catch y algún loop, pero como no los vimos lo dejo como está*/


        double @base = 0;
        double altura = 0;
        double resultado;


        Console.WriteLine("Escribe la base:");
        @base = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escribe la altura:");
        altura = Convert.ToDouble(Console.ReadLine());

        resultado = (@base * altura) / 2; 
        Console.WriteLine("El resultado es " + resultado + ".");
    }
}