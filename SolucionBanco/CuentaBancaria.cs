using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBanco
{
    public class CuentaBancaria
    {
        public string NumeroCuenta { get; set; }
        public decimal Saldo { get; set; }

        public CuentaBancaria(string numero) 
        {
            NumeroCuenta = numero;
            Saldo = 0; 
        }

        public void Depositar(decimal monto)
        { 
            Saldo += monto;
            Console.WriteLine("Deposito Realizado con exito. Su saldo actual es: $" + Saldo );
        }

        public void Retirar(decimal monto)
        {
            if (monto > Saldo)
            {
                Console.WriteLine("No hay fondos suficientes para realizar la extracción.");
            }
            else
            {
                Saldo -= monto;
            }
        }

        public void Transferir(CuentaBancaria destino, decimal monto)
        {
            if (monto > Saldo)
            {
                Console.WriteLine("No puso realizarse la transferencia. Fondos Insuficientes.");
            }
            else
            {
                Saldo -= monto;
                destino.Saldo += monto;
                Console.WriteLine("Se realizo exitosamente una transferencia por $" + monto + " a la cuenta: " + destino.NumeroCuenta);
            }
        }


    }
}
