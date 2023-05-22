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
    internal class House
    {
        int doorsQuantity;
        int windowsQuantity;
        string color;
        string material;
        double height;

        public void SetDoorsQuantity(int doorsQuantity)
        {
            this.doorsQuantity = doorsQuantity;
        }

        public void SetWindowsQuantity(int windowsQuantity)
        {
            this.windowsQuantity = windowsQuantity;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public void SetMaterial(string material)
        {
            this.material = material;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }


        public int GetDoorsQuantity()
        {
            return this.doorsQuantity;
        }

        public int GetWindowsQuantity()
        {
            return this.windowsQuantity;
        }

        public string GetColor()
        {
            return this.color;
        }

        public string GetMaterial()
        {
            return this.material;
        }

        public double GetHeight()
        {
            return this.height;
        }


        public void AddInfoHouse()
        {
            Console.Write("Ingrese cantidad de Puertas: ");
            SetDoorsQuantity(int.Parse(Console.ReadLine()));

            Console.Write("Cantidad de Ventanas: ");
            SetWindowsQuantity(int.Parse(Console.ReadLine()));

            Console.Write("Ingrese el color: ");
            SetColor(Console.ReadLine());

            Console.Write("Ingrese el Material: ");
            SetMaterial(Console.ReadLine());

            Console.Write("Ingrese la altura:");
            SetHeight(double.Parse(Console.ReadLine()));
        }

        public void SeeInfoHouse()
        {
            Console.WriteLine("\nPuertas:" + GetDoorsQuantity() + " Ventanas:" + GetWindowsQuantity() + " Color:" + GetColor() + " Material:" + GetMaterial() + " Altura:" + GetHeight());
            Console.ReadLine();
        }


    }
}
