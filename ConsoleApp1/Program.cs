namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta = new CuentaBancaria();
            GestorCuenta gestorCuenta = new GestorCuenta(cuenta);

            cuenta.NoCuenta = "9876543210";
            cuenta.Propietario = "Gerson";
            gestorCuenta.Depositar(100);
            gestorCuenta.Retirar(50);

            Console.WriteLine("Numero de Cuenta: " + cuenta.NoCuenta);
            Console.WriteLine("Usuario: " + cuenta.Propietario);
            decimal saldoActual = cuenta.Saldo;
            Console.WriteLine("Saldo actual: " + saldoActual);
        }
    }
}