using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Trabajo_Grupal_1
{
    internal class Mascota
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Especie Especie { get; set; }

        public string ObtenerNombre()
        {
            return this.Nombre;
        }

        public int ObtenerEdad()
        {
            return this.Edad;
        }

        public Especie ObtenerEspecie()
        {
            return this.Especie;
        }


        public void DarNombre(string nombre)
        {

            this.Nombre = nombre;
        }

        public void DarEdad(int edad)
        {
            this.Edad = edad;
        }

        public void DarEspecie(Especie especie)
        {
            this.Especie = especie;
        }

        public void HacerSonido()
        {
            if (this.Especie.Nombre == "Gato")
            {
                Console.WriteLine("Miauuu");
            }
            else
                Console.WriteLine("Guauuu");
        }

        public void Moverse()
        {
            Console.WriteLine(this.Nombre + " se mueve.");
        }



    }
}
