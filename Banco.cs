using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{

public class Banco
{
    private string name;
    private string direction;
    public List<Client> clients { get; set; }
    private int clientsQuantity;
    public Banco()
	{
            this.clients = new List<Client>();
            this.clientsQuantity = 0;
    }

    public Banco(string name, string direction, int clients)
	{
            this.name = name;
            this.direction = direction;
            this.clientsQuantity = 0;
            this.clientsQuantity = clients;
            this.clients = new List<Client>();
            for(int i = 0; i < clients; i++)
            {
                this.clients.Add(new Client(i+1, "Client"+(i+1), 0));

            }
	}

    //setters
    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetDirection(string direction)
    {
        this.direction = direction;
    }
    public void SetClientsQuantity(int quantity)
    {
        this.clientsQuantity = quantity;
    }
    //getters

    public string GetName()
    {
        return this.name;
    }
    public string GetDirection()
    {
        return this.direction;
    }
    public int GetClientsQuantity()
    {
        return this.clientsQuantity;
    }

    public void AddClient(Client client)
    {
        this.clients.Add(client);
        this.clientsQuantity++;
            Console.WriteLine("New client added! Welcome " + client.Name + "!");
    }   

    public void RemoveClient(Client client)
    {
        if(this.clientsQuantity <= 0)
            {
                Console.WriteLine("There is not clients");
            }
            else
            {
                if(clients.Contains(client)) { 
                    this.clients.Remove(client);
                    this.clientsQuantity--;
                }
                else
                {
                    Console.WriteLine("That client does not exist");
                }
            }
    }

    public void DepositTo(Client client, double amount)
        {
            client.Balance += amount;
        }

    public void WithdrawFrom(Client client, double amount)
        {
            if(client.Balance >= amount)
            {
                client.Balance -= amount;

            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
    public void Transfer(Client client1, Client client2, double amount)
    {
            if(client1.Balance >= amount)
            {
                client1.Balance -= amount;
                client2.Balance += amount;
                Console.WriteLine("Successful transfer");
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
    }
}

/*nombre, direccion, nroCLientes, 
 metodos: 
 agregar y eliminar Clientes
Realizar transsaciones como depositos, retiros y transferencias entre cuentas
 */

}