using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utn._2023.programacion
{
  public class Libro
  {
    public Libro(string Titulo, string Autor, string Editorial, string ISBN)
    {
      this.Titulo = Titulo;
      this.Autor = Autor;
      this.Editorial = Editorial;
      this.ISBN = ISBN;
    }
    private string Titulo { get; set; }
    private string Autor { get; set; }
    private string Editorial { get; set; }
    private string ISBN { get; set; }

    public void ImprimirInformacion() {
      Console.WriteLine("Título: " + this.Titulo);
      Console.WriteLine("Autor: " + this.Autor);
      Console.WriteLine("Editorial: " + this.Editorial);
      Console.WriteLine("ISBN: " + this.ISBN);
    }
  }
}
