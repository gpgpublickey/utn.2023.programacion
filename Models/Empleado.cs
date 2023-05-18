using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float Salario { get; set; }


        public Empleado(string nombre, float salario ) 
        { 
            Nombre = nombre;
            Salario = salario;
        }

        public void AumentarSalario(Empleado empleado, float salarioNuevo) 
        { 
            if(empleado!=null)
            {
                empleado.Salario = salarioNuevo;
            }
            
        }
        public float CalcularSalarioAnual(Empleado empleado)
        {
            float salarioAnual = empleado.Salario * 12;
            return salarioAnual;
        }

    }
}
