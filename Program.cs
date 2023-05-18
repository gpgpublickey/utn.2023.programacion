//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ConsoleApp.Models;

class Program
{

    private static void Main(String[] args)
    {
        string nombre = "Pepe";
        float salario = 25;
       
        Empleado empleado = new Empleado(nombre, salario);

    }
}