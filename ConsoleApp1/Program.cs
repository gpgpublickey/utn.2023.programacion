namespace ConsoleApp1
{ 
    internal class Program
    {
        static void Main(string[] args)
        {

            // CLASE Cuenta
            Cuenta cuenta = new Cuenta();

            // Setters

            cuenta.NoCuenta = "9876543210";
            cuenta.Propietario = "Gerson";
            cuenta.Saldo = 1000;

            // Getters

            Console.WriteLine("Numero de Cuenta: " + cuenta.NoCuenta);
            Console.WriteLine("Usuario: " + cuenta.Propietario);
            Console.WriteLine("Dinero en cuenta: " + cuenta.Saldo);

            cuenta.Depositar(1200);
            Console.WriteLine("El saldo ahora es de: " + cuenta.Saldo);

            cuenta.Retirar(2000);
            Console.WriteLine("El saldo ahora es de: " + cuenta.Saldo);

        }
    }
}