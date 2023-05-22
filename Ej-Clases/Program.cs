using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1- Crear una clase casa que tenga atributos cantidad de puertas, 
ventanas, color exterior, material, altura y sus metodos 
para acceder y especificar estos atributos.
*/

namespace Ej_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            //house.SetDoorsQuantity(5);
            //house.SetWindowsQuantity(2);
            //house.SetColor("Blanco");
            //house.SetMaterial("Cemento");
            //house.SetHeight(3.55);

            /*
            Console.Write("Ingrese cantidad de Puertas: ");
            house.SetDoorsQuantity(int.Parse(Console.ReadLine()));
            
            Console.Write("Cantidad de Ventanas: ");
            house.SetWindowsQuantity(int.Parse(Console.ReadLine()));
            
            Console.Write("Ingrese el color: ");
            house.SetColor(Console.ReadLine());

            Console.Write("Ingrese el Material: ");
            house.SetMaterial(Console.ReadLine());

            Console.Write("Ingrese la altura:");
            house.SetHeight(double.Parse(Console.ReadLine()));

            Console.WriteLine("Puertas:" + house.GetDoorsQuantity()+ " Ventanas:"+ house.GetWindowsQuantity()+ " Color:"+ house.GetColor()+ " Material:"+ house.GetMaterial()+ " Altura:"+house.GetHeight());
            Console.ReadLine();
            */

            house.AddInfoHouse();
            house.SeeInfoHouse();
        }
    }
}
