
/*
Banco con nombre direcc y can clientes. Agregar y eliminar clientes, transacciones bancarias... depos retiros y transf
*/
public class Cliente
{
    public string Nombre
    {
        get { return Nombre; }
        set { Nombre = value; }
    }
    private string Direccion{get;set;}
    private string Email{get;set;}

    

    public Cliente(string Name, string Direccion, string Email)
    {
        this.Nombre = Name;
        this.Direccion = Direccion;
        this.Email = Email;

    }


}