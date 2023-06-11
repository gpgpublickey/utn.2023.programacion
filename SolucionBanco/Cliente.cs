using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBanco
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<CuentaBancaria> Cuentas { get; set; }


        public Cliente(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
            Cuentas = new List<CuentaBancaria>();
        }

        public void AgregarCuenta(CuentaBancaria cuenta)
        { 
            Cuentas.Add(cuenta);
        }

        public void BorrarCuenta(CuentaBancaria cuenta)
        {   
            Cuentas.Remove(cuenta);
        }
    }
}
