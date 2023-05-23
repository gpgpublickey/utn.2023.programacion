using Trabajo_Grupal_1;

internal class Program
{
    private static void Main(string[] args)
    {
        //Perro Loli.
        Perro perro1 = new Perro();
        perro1.DarNombre("Loli");
        perro1.DarEdad(5);

        //Gata Sanah.
        Gato gata1 = new Gato();
        gata1.DarNombre("Sanah");
        gata1.DarEdad(3);

        //Llamar métodos.
        perro1.HacerSonido();
        perro1.Moverse();

        gata1.HacerSonido();
        gata1.Moverse();

        Console.ReadLine();
    }
}