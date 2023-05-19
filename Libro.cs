using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utn._2023.programacion
{
  public class Libro
  {
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Editorial { get; set; }
    public string ISBN { get; set; }

    public void ImprimirInformacion() {
      Console.WriteLine("Título: " + this.Titulo);
      Console.WriteLine("Autor: " + this.Autor);
      Console.WriteLine("Editorial: " + this.Editorial);
      Console.WriteLine("ISBN: " + this.ISBN);
    }
  }
}
