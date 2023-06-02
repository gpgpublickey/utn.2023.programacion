//esta clase tiene los métodos para resolver los primeros 10 puntos de la práctica
//todos los métodos trabajan con la precisión del double
namespace operadores_aritmeticos
{
  internal static class HelperOperadores
  {
    public static double Sumar(double a, double b)
    {
      return a + b;
    }

    public static double Restar(double a, double b)
    {
      return a - b;
    }

    public static double Multiplicar(double a, double b)
    {
      return a * b;
    }

    public static double Dividir(double a, double b)
    {
      if (b != 0) {
        return a / b;
      } else {
        return double.NaN;
      }
     }

    public static double Modulo(double a, double b)
    {
      return a % b;
    }

    public static double Potencia(double a, double b)
    {
      return Math.Pow(a,b);
    }

    public static double PromediarDe3(double a, double b, double c)
    {
      return (a + b + c)/3 ;
    }

    public static double CalcularAreaTriangulo(double b, double h)
    {
      return (b * h) / 2;
    }

    public static double CalcularPerimetroCirculo(double r)
    {
      return 2 * Math.PI * r;
    }

    public static double CalcularGradosFahrenheit(double c)
    {
      return c * 9/5 + 32;
    }
  }
  
}