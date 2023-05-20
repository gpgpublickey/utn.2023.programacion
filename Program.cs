//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ConsoleApp.Models;

class Program
{

    private static void Main(String[] args)
    {
        Console.WriteLine("Ejercicio clase 17/5/2023");
        string nombre = "Pepe";
        float salario = 25;

        Empleado empleado = new (nombre, salario);
        Console.WriteLine("Nombre empleado: " + empleado.Nombre);
        Console.WriteLine("Salario empleado: " + empleado.Salario);

        Console.WriteLine();

        Console.WriteLine("Ejercicio clase 19/5/2023");
        Computadora computadora = new (true, false, true, "X-10", "Intel 8008", "Nvidia GTX 1660");
        Console.WriteLine("La computadora tiene:");
        Console.WriteLine("Teclado: " + (computadora.Teclado? "Tiene" : "No tiene"));
        Console.WriteLine("Mouse: " + (computadora.Mouse ? "Tiene" : "No tiene"));
        Console.WriteLine("Monitor: " + (computadora.Monitor ? "Tiene" : "No tiene"));
        Console.WriteLine("Descricion de Modelo: " + computadora.Modelo);
        Console.WriteLine("Descricion de Microprocesador: " + computadora.ModeloMicroprocesador);
        Console.WriteLine("Descricion de Tarjeta Grafica: " + computadora.TarjetaGrafica);

        Console.ReadLine();
    }
}