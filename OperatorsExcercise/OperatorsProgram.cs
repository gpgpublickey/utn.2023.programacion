using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utn._2023.programacion.OperatorsExcercise;

    public class OperatorsProgram
    {
    public static void RunOperatorsProgram()
    {
        float a = 10;
        float b = 5;
        float cero = 0;
        float c = 3;

        Console.WriteLine("Suma de " + a + " + " + b + ":");
        Console.WriteLine(Calculator.Sumar(a, b));


        Console.WriteLine("\nResta de " + a + " - " + b + ":");
        Console.WriteLine(Calculator.Restar(a, b));

        Console.ReadLine();
        Console.WriteLine("\nMultiplicación de " + a + " * " + b + ":");
        Console.WriteLine(Calculator.Multiplicar(a, b));

 
        try {
            Console.WriteLine("\nDivisión de " + a + " / " + b + ":");
            Console.WriteLine(Calculator.Dividir(a, b));

            Console.WriteLine("\nDivisión de " + a + " / " + cero + ":");
            Console.WriteLine(Calculator.Dividir(a, cero));
        } catch (Exception ex) { 
            Console.WriteLine(ex.Message); 
        }

        Console.ReadLine();
        try
        {
            Console.WriteLine("\nResto de " + a + " / " + b + ":");
            Console.WriteLine(Calculator.Resto(a, b));

            Console.WriteLine("\nResto de " + a + " / " + cero + ":");
            Console.WriteLine(Calculator.Resto(a, cero));

            Console.WriteLine("\nResto de " + a + " / " + c + ":");
            Console.WriteLine(Calculator.Resto(a, c));
        } catch (Exception ex) { 
                Console.WriteLine(ex.Message); 
        }
        Console.ReadLine();

        Console.WriteLine("\nCálculo de " + a + " al cuadrado");
        Console.WriteLine(Calculator.ElevarAlCuadrado((int)a));

        Console.WriteLine("\nPromedio entre " + a + ", " + b + " y "+ c +":");
        Console.WriteLine(Calculator.PromedioDeTresNumeros(a,b, c));

        Console.WriteLine("\nCálculo del area de un triángulo..");
        Console.WriteLine("\nIngrese la base del triángulo: ");
        float input1 = float.Parse(Console.ReadLine());
        Console.WriteLine("\nIngrese la altura del triángulo: ");
        float input2 = float.Parse(Console.ReadLine());
        Console.WriteLine("\nEl area del triángulo es: " + Calculator.AreaTriangulo(input1, input2));

        Console.WriteLine("\nCálculo del perimetro de un círculo..");
        Console.WriteLine("\nIngrese el radio del circulo: ");
        input1 = float.Parse(Console.ReadLine());
        Console.WriteLine("\nEl perímetro del círculo es: " + Calculator.Perimetro(input1));

        Console.WriteLine("\nConversión de grados Celsius a grados Fahrenheit..");
        Console.WriteLine("\nIngrese la temperatura en grados Celsius: ");
        input1 = float.Parse(Console.ReadLine());
        Console.WriteLine("\n" + input1 +"° Celsius es equivalente a " + Calculator.CelsiusAFahrenheit(input1) + "° Fahrenheit.");

    }

    }

