using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utn._2023.programacion.OperatorsExcercise;

public class Calculator
{
    public Calculator() { }
    public static float Sumar(float a, float b)
    {
        return a + b;
    }

    public static float Restar(float a, float b)
    {
        return a - b;
    }

    public static float Multiplicar(float a, float b)
    {
        return a * b;
    }

    public static float Dividir(float a, float b)
    {
        if (b == 0)
        {
            throw new Exception("No se puede dividir entre 0");               
        }
        return a / b;
    }

    public static float Resto(float a, float b)
    {
        if (b == 0)
        {
            throw new Exception("No se puede dividir entre 0");
        }
        return a % b;
    }

    public static int ElevarAlCuadrado(int a)
    {
        return (int)Math.Pow(a, 2);
    }

    public static float PromedioDeTresNumeros(float a, float b, float c)
    {
        return (a + b + c) / 3;
    }

    public static float AreaTriangulo(float b, float h)
    {
        return (b * h) / 2;
    }

    public static float Perimetro(float radio)
    {
        return (float)(2 * Math.PI * radio);
    }

    public static float CelsiusAFahrenheit(float gradosCelsius)
    {
        return (gradosCelsius * 9 / 5) +32; 
    }
}
