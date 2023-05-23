using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Trabajo_Grupal_1
{
    internal class Mascota
    {
        private string Nombre;
        private int Edad;
        public string ObtenerNombre()
        {
            return this.Nombre;
        }

        public int ObtenerEdad()
        {
            return this.Edad;
        }

        public void DarNombre(string nombre)
        {

            this.Nombre = nombre;
        }

        public void DarEdad(int edad)
        {
            this.Edad = edad;
        }
    }
}
