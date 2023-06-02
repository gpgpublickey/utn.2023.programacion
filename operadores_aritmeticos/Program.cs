namespace operadores_aritmeticos
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("SUMA");
      var resultadoSuma = HelperOperadores.Sumar(3, 10);
      var resultadoSuma2 = HelperOperadores.Sumar(5.5, 7.5);
      Console.WriteLine("Resultado primera suma: " + resultadoSuma);
      Console.WriteLine("Resultado segunda suma: " + resultadoSuma2);
      Console.WriteLine("\n");

      Console.WriteLine("RESTA");
      var resultadoResta = HelperOperadores.Restar(23, 10);
      var resultadoResta2 = HelperOperadores.Restar(25.5, 8);
      Console.WriteLine("Resultado primera resta: " + resultadoResta);
      Console.WriteLine("Resultado segunda resta: " + resultadoResta2);
      Console.WriteLine("\n");

      Console.WriteLine("MULTIPLICACION");
      var resultadoMultiplicacion = HelperOperadores.Multiplicar(2, 10);
      var resultadoMultiplicacion2 = HelperOperadores.Multiplicar(2.5, 4);
      Console.WriteLine("Resultado primera multiplicación: " + resultadoMultiplicacion);
      Console.WriteLine("Resultado segunda multiplicación: " + resultadoMultiplicacion2);
      Console.WriteLine("\n");

      Console.WriteLine("DIVISION");
      var resultadoDivision = HelperOperadores.Dividir(200, 10);
      var resultadoDivision2 = HelperOperadores.Dividir(9.5, 0);
      if (double.IsNaN(resultadoDivision)) {
        Console.WriteLine("No se puede dividir por cero.");
      } else {
        Console.WriteLine("Resultado primera división: " + resultadoDivision);
      }
      if (double.IsNaN(resultadoDivision2))
      {
        Console.WriteLine("No se puede dividir por cero.");
      } else
      {
        Console.WriteLine("Resultado segunda división: " + resultadoDivision2);
      }
      Console.WriteLine("\n");

      Console.WriteLine("POTENCIA");
      var resultadoPotencia = HelperOperadores.Potencia(2, 5);
      var resultadoPotencia2 = HelperOperadores.Potencia(9.5, 0);
      Console.WriteLine("Resultado primera potencia: " + resultadoPotencia);
      Console.WriteLine("Resultado segunda potencia: " + resultadoPotencia2);
      Console.WriteLine("\n");

      Console.WriteLine("PROMEDIO DE 3 NUMEROS");
      var resultadoPromedio = HelperOperadores.PromediarDe3(11, 9, 19);
      Console.WriteLine("Resultado promediar entre 3: " + resultadoPromedio);
      Console.WriteLine("\n");

      //para los siguientes casos asumo que el usuario va a ingresar numeros
      Console.WriteLine("AREA TRIANGULO");
      Console.WriteLine("Ingrese de la base: ");
      var baseTriangulo = Console.ReadLine();
      Console.WriteLine("Ingrese la altura: ");
      var alturaTriangulo = Console.ReadLine();
      var resultadoArea = HelperOperadores.CalcularAreaTriangulo(double.Parse(baseTriangulo), double.Parse(alturaTriangulo));
      Console.WriteLine("Resultado cálculo de área: " + resultadoArea);
      Console.WriteLine("\n");

      Console.WriteLine("PERIMETRO CIRCULO");
      Console.WriteLine("Ingrese el valor del radio: ");
      var radio = Console.ReadLine();
      var resultadoPerimetro = HelperOperadores.CalcularPerimetroCirculo(double.Parse(radio));
      Console.WriteLine("Resultado cálculo de perímetro: " + resultadoPerimetro);
      Console.WriteLine("\n");

      Console.WriteLine("CONVERSION CELSIUS A FAHRENHEIT");
      Console.WriteLine("Ingrese el valor de la temperatura en grados Celsius: ");
      var grados = Console.ReadLine();
      var resultadoConversion = HelperOperadores.CalcularGradosFahrenheit(double.Parse(grados));
      Console.WriteLine("Valor en grados Fahrenheit: " + resultadoConversion);
      Console.WriteLine("\n");

      Console.WriteLine("||CALCULADORA||");
      Console.WriteLine("Ingrese 'y' para activar la calculadora");
      var quiereCalculadora = Console.ReadKey();
      if (quiereCalculadora.KeyChar.ToString() == "y")
      {
        Console.Clear();
        CalculatorInterface calculadora = new CalculatorInterface();
        calculadora.Activate();

      }

    }
  }
}
