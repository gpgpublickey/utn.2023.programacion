internal class Program
{
    private static void Main(string[] args)
    {

        //En este manejé la chance de que ponga 0 como segundo número.


        double num1 = 0;
        double num2 = 0;
        double resultado;


        Console.WriteLine("Escribe el primer número:");
        num1 = Convert.ToDouble(Console.ReadLine());

        while (num2 == 0)
        {
            Console.WriteLine("Escribe el segundo número:");
            num2 = Convert.ToDouble(Console.ReadLine());

        if (num2 == 0)
             Console.WriteLine("No puede ser 0.");
        }

        resultado = num1 / num2;
        Console.WriteLine("El resultado es " + resultado + ".");
    }
}