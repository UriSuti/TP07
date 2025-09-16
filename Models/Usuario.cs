namespace TP07.Models;

public class Usuario 
{
    public string nombre { get; private set; }
    public int cantidadIntentos { get; private set; }
    public Usuario(string nombre, int cantidadIntentos)
    {
        this.nombre = nombre;
        this.cantidadIntentos = cantidadIntentos;
    }
}