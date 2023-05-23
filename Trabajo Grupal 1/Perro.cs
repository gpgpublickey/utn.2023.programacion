using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Grupal_1
{
    internal class Perro:Mascota, IEspecie
    {
        public void HacerSonido()
        {
            Console.WriteLine("Guuauuu.");
        }

        public void Moverse()
        {
            Console.WriteLine("El perro se mueve moviendo la cola.");
        }
    }
}
