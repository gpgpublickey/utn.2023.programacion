
/*
Banco con nombre direcc y can clientes. Agregar y eliminar clientes, transacciones bancarias... depos retiros y transf
*/
public class Banco
{
    private string Nombre{get;set;}
    private string Direccion{get;set;}
    private int CantClientes{get;set;}
    private List<Cliente> Clientes{get;set;}

    public Banco(string Name, string Direccion)
    {
        this.Nombre = Name;
        this.Direccion = Direccion;
    }

    public void AgregarCliente(Cliente clienteNuevo)
    {
        Clientes.Add(clienteNuevo);
        CantClientes++;
    }

    public void EliminarCliente(Cliente clienteEliminar)
    {

        CantClientes--;
    }

}