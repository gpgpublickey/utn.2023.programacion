using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GestorCuenta
    {
        private CuentaBancaria cuenta;

        public GestorCuenta(CuentaBancaria cuenta)
        {
            this.cuenta = cuenta;
        }

        public void Depositar(decimal cantidad)
        {
            cuenta.Depositar(cantidad);
        }

        public void Retirar(decimal cantidad)
        {
            cuenta.Retirar(cantidad);
        }
    }
}
