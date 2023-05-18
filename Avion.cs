/*Crea un avion, Modelo Capacidad Velocidad maxima Metodos para despegar y aterrizar y volar en dif altitudes*/
/*Crea un avion, Modelo Capacidad Velocidad maxima Metodos para despegar y aterrizar y volar en dif altitudes*/
public class Avion
{
    private string Modelo;
    private int Capacidad;
    private float VelocidadMAX;
    private float Altitud;

    public Avion(string Model, int Capacity, float MaxSpeed)
    {
        this.Modelo = Model;
        this.Capacidad = Capacity;
        this.VelocidadMAX = MaxSpeed;
        this.Altitud = 0;

    }

    public string getModelo(){
        return Modelo;
    }
    public int getCapacidad(){
        return Capacidad;
    }
    public float getVelocidadMAX(){
        return VelocidadMAX;
    }
    public float getAltitud(){
        return Altitud;
;
    }
    public void setModelo(string NameModel){
        this.Modelo = NameModel;

    }
    public void setCapacidad(int NewCapacity){
        this.Capacidad = NewCapacity;

    }
    public void setVelocidadMAX(float NewMaxSpeed){
        this.VelocidadMAX = NewMaxSpeed;

    }



    public void Despegar()
    {
        this.Altitud = 1000;
        Console.WriteLine("El avion " + this.Modelo + " despego!");
    }

    public void Aterrizar()
    {
        CambiarAltitud(0);
        Console.WriteLine("El avion " + this.Modelo + " aterrizo!");

    }

    public void CambiarAltitud(int Alt)
    {
        if(Altitud != 0){
            this.Altitud = Alt;
        }
        else{
            Console.WriteLine("El avion " + this.Modelo + " todavía no despego!");
        }

    }
}