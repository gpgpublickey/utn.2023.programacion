using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utn._2023.programacion
{
  public abstract class Libro : Informable
  {
    
    private string Titulo { get; set; }
    private string Autor { get; set; }
    private string Editorial { get; set; }
    private string ISBN { get; set; }
    private short CantidadPaginas { get; set; }

    public Libro(string Titulo, string Autor, string Editorial, string ISBN, short CantidadPaginas)
    {
      this.Titulo = Titulo;
      this.Autor = Autor;
      this.Editorial = Editorial;
      this.ISBN = ISBN;
      this.CantidadPaginas = CantidadPaginas;
    }

    public virtual void ImprimirInformacion()
    {
      Console.WriteLine("Título: " + this.Titulo);
      Console.WriteLine("Autor: " + this.Autor);
      Console.WriteLine("Editorial: " + this.Editorial);
      Console.WriteLine("ISBN: " + this.ISBN);
      Console.WriteLine("Cant. de páginas: " + this.CantidadPaginas);
    }
  }
}
