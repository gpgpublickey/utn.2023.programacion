using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utn._2023.programacion
{
  internal class LibroElectronico : Libro
  {
    private float TamañoArchivo { get; set; }
    private string Formato { get; set; }
    public LibroElectronico(string Titulo, string Autor, string Editorial, string ISBN, short CantidadPaginas, float TamañoArchivo, string Formato) : base(Titulo, Autor, Editorial, ISBN, CantidadPaginas)
    {
      this.TamañoArchivo = TamañoArchivo;
      this.Formato = Formato;
    }

    public override void ImprimirInformacion()
    {
      base.ImprimirInformacion(); //esto es lo de Libro
      Console.WriteLine("Tamaño del archivo en MB: " + this.TamañoArchivo);
      Console.WriteLine("Formato del archivo: " + this.Formato);
    }
  }
}
