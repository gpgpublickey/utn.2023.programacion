using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    internal class Computadora
    {
        public Computadora(bool teclado, bool mouse, bool monitor, string modelo, string modeloMicroprocesador, string tarjetaGrafica)
        {
            this.Teclado = teclado;
            this.Mouse = mouse;
            this.Monitor = monitor;
            this.Modelo = modelo;
            this.ModeloMicroprocesador = modeloMicroprocesador;
            this.TarjetaGrafica = tarjetaGrafica;
        }

        public bool Teclado { get; set; }

        public bool Mouse { get; set; }

        public bool Monitor { get; set; }

        public string Modelo { get; set; }

        public string ModeloMicroprocesador { get; set; }

        public string TarjetaGrafica { get; set; }

    }
}
