using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cuenta
    {
        public string NoCuenta { get; set; }
        public string Propietario { get; set; }
        public decimal Saldo { get; set; }

        public decimal Depositar(decimal deposito)
        {
            Saldo += deposito;
            return Saldo;
        }

        public decimal Retirar(decimal retiro)
        {
            if (Saldo > retiro)
            {
                Saldo -= retiro;
                return Saldo;
            }
            else
            {
                Console.WriteLine("Fondos Insuficientes");
            }
            return Saldo;
        }
    }
}