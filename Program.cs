namespace utn._2023.programacion
{
  class Program
  {
    static void Main(string[] args)
    {
      Libro libro = new Libro();
      libro.Autor = "Cosme Fulanito";
      libro.Titulo = "Yo soy Cosme Fulanito";
      libro.Editorial = "Planeta";
      libro.ISBN = "1234567890";
      libro.ImprimirInformacion();
    }
  }
}
