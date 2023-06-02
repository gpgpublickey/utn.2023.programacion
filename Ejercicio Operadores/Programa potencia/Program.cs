internal class Program
{
    private static void Main(string[] args)
    {
        /*No se maneja la posibilidad de que el usuario ingrese un input incorrecto, creo que eso requeriría
          * Try y Catch y algún loop, pero como no los vimos lo dejo como está*/


        double num1 = 0;
        double num2 = 0;
        double resultado;


        Console.WriteLine("Escribe el primer número:");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escribe el segundo número:");
        num2 = Convert.ToDouble(Console.ReadLine());

        resultado = Math.Pow(num1, num2); ;
        Console.WriteLine("El resultado es " + resultado + ".");
    }
}