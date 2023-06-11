class Promedio {

    static double CalcularPromedio(double valor1=0, double valor2=0, double valor3=0)
    {
        double promedio = (valor1 + valor2 + valor3) / 3;
        return promedio;
    }   

    public static void Main() {
        int off = 0;
        string input;

        while (off == 0)
        {
            Console.WriteLine("Ingrese hasta 3 numeros:");

            Console.Write("Numero 1: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Numero 2: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Numero 3: ");
            double numero3 = Convert.ToDouble(Console.ReadLine());

            double promedio = CalcularPromedio(numero1, numero2, numero3);
            Console.WriteLine("El promedio es: " + promedio);
            System.Threading.Thread.Sleep(750);
            Console.WriteLine("Desea calcular otro promedio? Y/N: ");
            input = Console.ReadLine().ToUpper();

            if (input != "Y") 
            {
                off = 1;
            }
        }
    }
}