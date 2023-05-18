internal class Juego
{
    /*
    Crea una clase juego que tenga atributos como nombre, descripccion,
    categoria, orecio  y metodos para ininicar, pausar y detener el juego
     */
    public string Name { get; set; }
    public string Description { get; set; }
    public string Categoria { get; set; }
    public double Precio { get; set; }

    public Juego() { }
    public Juego(string name, string description, string categoria, double precio)
    {
        Name = name;
        Description = description;
        Categoria = categoria;
        Precio = precio;
    }

    public void StartGame()
    {
        Console.WriteLine("The game " + this.Name + " is running!");
    }

    public void PauseGame()
    {
        Console.WriteLine("Game paused");
    }

    public void StopGame()
    {
        Console.WriteLine("Game Over");
    }




}

