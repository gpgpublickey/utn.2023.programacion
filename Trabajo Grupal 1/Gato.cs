using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Grupal_1
{
    internal class Gato:Mascota, IEspecie
    {
        public void HacerSonido()
        {
            Console.WriteLine("Miaaaauu.");
        }

        public void Moverse()
        {
            Console.WriteLine("El gato se mueve por sigilosamente.");
        }
    }
}
