namespace EjercicioClase3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coche = new Coche();

            coche.Modelo = "R12";
            coche.Marca = "Renault";
            coche.Año = 1980;

            coche.pasarMarcha("N");
            coche.Acelerar(130);
            coche.Frenar(30);

            Console.WriteLine("\nMarca: " + coche.Marca);
            Console.WriteLine("Modelo: " + coche.Modelo);
            Console.WriteLine("Año: " + coche.Año.ToString());
        }
    }
}