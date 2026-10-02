namespace Clases;

public class Persona
{
    public string nombre;
    public string telefono; //+51987232322
    public int prioridad; //0,1

    public Persona(string nombre, string telefono, int prioridad)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        this.prioridad = prioridad;
    }
}