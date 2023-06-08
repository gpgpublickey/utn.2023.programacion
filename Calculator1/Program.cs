namespace Calculator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso
            Calculator calculator = new Calculator();

            // Registro de operaciones
            calculator.RegisterOperation('+', new Suma());
            calculator.RegisterOperation('-', new Resta());
            calculator.RegisterOperation('*', new Multiplicacion());
            calculator.RegisterOperation('/', new Division());

            // Realización de cálculos
            Console.WriteLine(calculator.Calcular('+', 4, 2));  // Resultado: 6
            Console.WriteLine(calculator.Calcular('-', 4, 2));  // Resultado: 2
            Console.WriteLine(calculator.Calcular('*', 4, 2));  // Resultado: 8
            Console.WriteLine(calculator.Calcular('/', 4, 2));  // Resultado: 2
           

        }
    }
}