
using utn._2023.programacion.OperatorsExcercise;

namespace utn._2023.programacion
{


class Program
    {
        static void Main(string[] args)
        {
            //Tarea Ejercicios varios
            /*
            Juego juego = new Juego("MGS", "Some description", "Accion", 200);



            juego.Name = "Test";
            juego.StartGame();
            juego.PauseGame();
            juego.StopGame();

            Console.ReadLine();

            //juego.SetName("MGS");
            //juego.SetDescription("Some description");
            //juego.SetCategoria("Accion");
            //juego.SetPrecio(200);

            Avion a1 = new Avion("Boing747", 200, 750);

            a1.CambiarAltitud(500);
            a1.Despegar();
            Console.WriteLine(a1.getAltitud());
            a1.CambiarAltitud(500);
            Console.WriteLine(a1.getAltitud());
            a1.Aterrizar();
            Console.WriteLine(a1.getAltitud());

            Console.ReadLine();

                Banco banco = new Banco("MyBank","Central Park", 0);
                Console.WriteLine("New bank " + banco.GetName() + " created!\n");
                Client client1 = new Client(1, "Fepo", 0);
                Client client2 = new Client(2, "Fido", 0);

                banco.AddClient(client1);
                banco.AddClient(client2);

                banco.DepositTo(client1, 2000);
                Console.WriteLine(client1.Name + "'s balance : " + client1.Balance);
                banco.DepositTo(client2, 2000);
                Console.WriteLine(client2.Name + "'s balance : " + client2.Balance);

                banco.Transfer(client2, client1, 500);
                Console.WriteLine(client1.Name + "'s balance : " + client1.Balance);
                Console.WriteLine(client2.Name + "'s balance : " + client2.Balance);

                banco.Transfer(client2, client1, 3000);
                Console.WriteLine(client1.Name + "'s balance : " + client1.Balance);
                Console.WriteLine(client2.Name + "'s balance : " + client2.Balance);

            Console.WriteLine("The bank " + banco.GetName() + " has " + banco.GetClientsQuantity() + " clients.");
                foreach (Client c in banco.clients)
                {
                    Console.WriteLine(c.Name);
                }

            banco.RemoveClient(client2);
            Console.WriteLine("The bank " + banco.GetName() + " has " + banco.GetClientsQuantity() + " clients.");
                foreach (Client c in banco.clients)
                {
                    Console.WriteLine(c.Name);
                }

            */

            OperatorsProgram.RunOperatorsProgram();
        
        }

    }


}