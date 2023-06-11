namespace ProyectoBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco("DariusBank", "Av. Eduardo Madero 900");

            Cliente cliente1 = new Cliente("Dario Nuñez","Adolfo Berro 2754");
            Cliente cliente2 = new Cliente("Dario Nuñez Jr.", "Adolfo Berro 2754");

            banco.AgregarCliente(cliente1);
            banco.AgregarCliente(cliente2);

            CuentaBancaria cuenta1 = new CuentaBancaria("00173216549876541");
            CuentaBancaria cuenta2 = new CuentaBancaria("00173216549876542");

            Console.WriteLine(banco.Nombre + " actualmente tiene: " + banco.CantidadClientes + " clientes.");

            cliente1.AgregarCuenta(cuenta1);
            cliente2.AgregarCuenta(cuenta2);
            
            cuenta1.Depositar(2500);
            cuenta2.Retirar(2500);

            cuenta1.Transferir(cuenta2, 2000);
            cuenta2.Retirar(1500);

            cuenta1.Transferir(cuenta2, 99999);

            banco.EliminarCliente(cliente1);

            Console.WriteLine(banco.Nombre + " actualmente tiene: " + banco.CantidadClientes + " clientes.");
        }
    }
}