//Crea una calculadora usando principios SOLID que maneje las operaciones fundamentales de suma, resta, multiplicación y división
//este si en ingles

namespace operadores_aritmeticos
{
  //clase que maneja la interaccion con el usuario
  public class CalculatorInterface
  {
    private Calculator Calculator;

    public CalculatorInterface()
    {
      Calculator = new Calculator();  
    }


    private void ShowMenu()
    {
      Console.WriteLine("Ingrese la opción correspondiente para la operación que desee realizar:");
      Console.WriteLine("1. Suma");
      Console.WriteLine("2. Resta");
      Console.WriteLine("3. Multipliación");
      Console.WriteLine("4. División");
      Console.WriteLine("5. Salir");
    }

    private void ShowCurrentValue()
    {
      Console.WriteLine("Valor actual: " + Calculator.GetValue());
    }

    private double GetNewValue()
    {
      Console.WriteLine("Ingrese el valor: ");
      //no valida que sea un numero
      return double.Parse(Console.ReadLine());
    }

    /// <summary>
    /// Seria el metodo que 'prende' la calculadora
    /// </summary>
    public void Activate()
    { 
      const string Add = "1";
      const string Subtract = "2";
      const string Multiply = "3";
      const string Divide = "4";
      const string Quit = "5";
      bool quit = false; //true cuando el usuario dice que quiere salir
      var value = 0d; // aca se guarda el valor que ingresa el usuario, para no manejarlo desde GetNewValue()

      while (!quit)
      {
        ShowCurrentValue();
        ShowMenu();
        var input = Console.ReadLine();
        switch (input)
        {
          case Add:
            value = GetNewValue();
            Calculator.Add(value);
            break;
          case Subtract:
            value = GetNewValue();
            Calculator.Subtract(value);
            break;
          case Multiply:
            value = GetNewValue();
            Calculator.Multiply(value);
            break;
          case Divide:
            value = GetNewValue();
            Calculator.Divide(value);
            break;
          case Quit:
            quit = true;
            break;
          default:
            Console.WriteLine("Opción no válida, vuelva a intentarlo.");
            break;
        }
        Console.Clear(); //comentar para que se vea el mensaje de default
      }
      Console.WriteLine("FIN");
    }
  }

}
