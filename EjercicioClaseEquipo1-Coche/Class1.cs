using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase3
{
    public class Coche
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Año { get; set; }
        public double Velocidad { get; set; }
        public string Marcha { get; set; }

        public void Acelerar(double aceleracion)
        {
            if (this.Marcha == "N") 
            {
                Console.WriteLine("No se puede acelerar en punto Muerto (N).");
            }
            else
            {
                Velocidad += aceleracion;
                Console.WriteLine("(Acelerado) - Velocidad Actual: " + Velocidad + "km/h");
            }
        }

        public void Frenar(double desaceleracion) {
            if (desaceleracion <= Velocidad)
            {
                Velocidad -= desaceleracion;
                Console.WriteLine("(Frenado) - Velocidad Actual: " + Velocidad + "km/h");
            }
            else {
                Velocidad = 0;
                Console.WriteLine("El coche esta totalmente detenido.");
            }
        }

        public void pasarMarcha(String marcha) {
            switch (marcha) { 
                case "N":
                    Marcha = marcha;
                    Console.WriteLine("Transmision en punto muerto.");
                    break;
                case "1":
                    Marcha = marcha;
                    Console.WriteLine("Primera marcha.");
                    break;
                case "2":
                    Marcha = marcha;
                    Console.WriteLine("Segunda marcha.");
                    break;
                case "3":
                    Marcha = marcha;
                    Console.WriteLine("Tercera Marcha");
                    break;
                case "4":
                    Marcha = marcha;
                    Console.WriteLine("Cuarta marcha.");
                    break;
                case "5":
                    Marcha = marcha;
                    Console.WriteLine("Quinta marcha.");
                    break;
                case "R":
                    Marcha = marcha;
                    Console.WriteLine("Reversa acoplada.");
                    break;
                default:
                    Console.WriteLine("Marcha Ingresada no valida. (N/R/[1-5])");
                    break;
            }
        }
    }
}
