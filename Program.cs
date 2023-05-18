
class Program{



static void Main(string[] args){

// AVION
    Avion a1 = new Avion("Boing747",200,750);

    a1.CambiarAltitud(500);
    a1.Despegar();
    Console.WriteLine( a1.getAltitud());
    a1.CambiarAltitud(500);
    Console.WriteLine( a1.getAltitud());
    a1.Aterrizar();
    Console.WriteLine( a1.getAltitud());

// JUEGO
    Juego juego = new Juego("MGS", "Some description", "Accion", 200);    
    //juego.SetName("MGS");
    //juego.SetDescription("Some description");
    //juego.SetCategoria("Accion");
    //juego.SetPrecio(200);
    juego.Name = "Test";
    juego.StartGame();
    juego.PauseGame();
    juego.StopGame();

    Console.WriteLine(juego.Name);
    Console.ReadLine();

// BANCO
    Banco b1 = new Banco("Frances","aramb 2713");




}



}