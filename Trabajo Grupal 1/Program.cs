using Trabajo_Grupal_1;

internal class Program
{
    private static void Main(string[] args)
    {
        //Perros.
        Especie perro = new Especie("Perro");
        //Gatos.
        Especie gato = new Especie("Gato");

        //Perro Loli.
        Mascota Mascota1 = new Mascota();
        Mascota1.DarNombre("Loli");
        Mascota1.DarEdad(5);
        Mascota1.DarEspecie(perro);

        //Gata Sanah.
        Mascota Mascota2 = new Mascota();
        Mascota2.DarNombre("Sanah");
        Mascota2.DarEdad(3);
        Mascota2.DarEspecie(gato);

        //Llamar métodos.
        Mascota1.HacerSonido();
        Mascota1.Moverse();

        Mascota2.HacerSonido();
        Mascota2.Moverse();


        Console.ReadLine();

    }
}