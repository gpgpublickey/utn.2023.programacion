using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utn._2023.programacion
{
  public class LibroFisico : Libro
  {
    private double Alto { get; set; }
    public LibroFisico(string Titulo, string Autor, string Editorial, string ISBN, short CantidadPaginas, double Alto) : base(Titulo, Autor, Editorial, ISBN, CantidadPaginas)
    {
      this.Alto = Alto;
    }
    
    public override void ImprimirInformacion()
    {
      base.ImprimirInformacion(); //esto es lo de Libro
      Console.WriteLine("Altura en cm: " + this.Alto);
    }
  }
}
