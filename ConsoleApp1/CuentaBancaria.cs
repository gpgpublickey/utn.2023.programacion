using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CuentaBancaria
    {
        public string Propietario { get; set; }
        public string NoCuenta { get; set; }
        public decimal Saldo { get; private set; }
        
        public void Depositar(decimal cantidad)
        {
            Saldo += cantidad;
        }

        public void Retirar(decimal cantidad)
        {
            if (Saldo >= cantidad)
            {
                Saldo -= cantidad;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
    }

}
