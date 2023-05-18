using System;

public class Banco
{
    string name;
    string direction;
    //List<Client> clients; 
    int clientsQuantity;
    public Banco()
	{
	}

    //setters
    public void setName(string name)
    {
        this.name = name;
    }
    public void setDirection(string direction)
    {
        this.direction = direction;
    }
    public void setClientsQuantity(int quantity)
    {
        this.clientsQuantity = quantity;
    }
    //getters

    public string getName()
    {
        return this.name;
    }
    public string getDirection()
    {
        return this.direction;
    }
    public int getClientsQuantity()
    {
        return this.clientsQuantity;
    }

    public void addClient(/*Client client*/)
    {
        //this.clients.Add(client);
        this.clientsQuantity++;
    }

    public void removeClient(/*Client client*/)
    {
        //this.clients.Remove(client);
        this.clientsQuantity--;
    }
}

/*nombre, direccion, nroCLientes, 
 metodos: 
 agregar y eliminar Clientes
Realizar transsaciones como depositos, retiros y transferencias entre cuentas
 */
