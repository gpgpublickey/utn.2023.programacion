namespace utn._2023.programacion
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("~Primer libro~");
      Libro libroFisico = new LibroFisico("Yo soy Cosme Fulanito", "Cosme Fulanito", "Planeta", "1234567890", 345, 25.3);
      libroFisico.ImprimirInformacion();
      Console.WriteLine("\n~Segundo libro~");
      LibroElectronico libroElectronico = new LibroElectronico("Cosme Fulanito, el regreso", "Cosme Fulanito", "Planeta", "1234876797", 400, 4, "PDF");
      libroElectronico.ImprimirInformacion();
    }
  }
}
