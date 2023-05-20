using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBanco
{
    public class Banco
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int CantidadClientes { get; set; }
        public List<Cliente> Clientes { get; set; }

        public Banco(string nombre, string direccion) 
        {
            Nombre = nombre;
            Direccion = direccion;
            CantidadClientes = 0;
            Clientes = new List<Cliente>();
        }

        public void AgregarCliente(Cliente cliente) 
        { 
            Clientes.Add(cliente);
            CantidadClientes++;
            Console.WriteLine("Se dio de alta con exito al cliente: " + cliente.Nombre);
        }

        public void EliminarCliente(Cliente cliente)
        { 
            Clientes.Remove(cliente);
            CantidadClientes--;
            Console.WriteLine("Se elimino con exito al cliente: " + cliente.Nombre);
        }
    }
}
