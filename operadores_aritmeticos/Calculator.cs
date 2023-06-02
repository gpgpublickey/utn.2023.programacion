namespace operadores_aritmeticos
{
  //clase que realiza SOLO las operaciones, si es posible
  //podria implementar una interface que tenga estos metodos? si hubiera una calculadora cientifica habrian beneficios ------ por ahora no (VER)
  //podria ser una clase abstracta? tendria que cambiar CalculatorInterface.. si hubieran mas tipos de calculadora entonces si valdria la pena
  public class Calculator 
  {
    //la calculadora guarda solo un valor
    private double Value;

    public Calculator()
    {
      Value = 0d;
    }

    public double GetValue()
    {
      return Value;
    }

    public void Add(double value)
    {
      Value += value;
    }

    public void Subtract(double value)
    {
      Value -= value;
    }

    public void Divide(double value)
    {
      if (value != 0)
      {
        Value /= value;
      }
      else
      {
        Console.WriteLine("No se puede dividir por cero.");
      }
    }

    public void Multiply(double value)
    {
      Value *= value;
    }

  }
}