namespace NewConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var park1 = new Park();

            park1.SetName("Plaza del Avion");
            park1.SetAddress("Finca 6220");
            park1.SetPeople(20);
            park1.SetGames(3);

            Console.WriteLine("Park Name: " + park1.GetName()); 
            Console.WriteLine("Adrress: " + park1.GetAddress());
            Console.WriteLine("Num of People: " + park1.GetPeople());
            Console.WriteLine("Num of Games: " + park1.GetGames());
        }
    }
}