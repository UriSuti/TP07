namespace TP07.Models;

public class Juego
{
    private List<Palabra> listaPalabras;
    private List<Usuario> jugadores;
    private Usuario jugadorActual;

    public Juego()
    {
        this.listaPalabras = new List<Palabra>();
        this.jugadores = new List<Usuario>();
    }

    private void llenarListaPalabras()
    {
        listaPalabras.Add(new Palabra("perro", 1));
        listaPalabras.Add(new Palabra("gato", 1));
        listaPalabras.Add(new Palabra("elefante", 3));
        listaPalabras.Add(new Palabra("jirafa", 2));
        listaPalabras.Add(new Palabra("computadora", 4));
        listaPalabras.Add(new Palabra("programacion", 5));
        listaPalabras.Add(new Palabra("cielo", 1));
        listaPalabras.Add(new Palabra("montaña", 2));
        listaPalabras.Add(new Palabra("estrella", 3));
        listaPalabras.Add(new Palabra("biblioteca", 4));
        listaPalabras.Add(new Palabra("avion", 2));
        listaPalabras.Add(new Palabra("raton", 1));
        listaPalabras.Add(new Palabra("telefono", 2));
        listaPalabras.Add(new Palabra("ventana", 2));
        listaPalabras.Add(new Palabra("puerta", 1));
        listaPalabras.Add(new Palabra("manzana", 1));
        listaPalabras.Add(new Palabra("camion", 2));
        listaPalabras.Add(new Palabra("pelicula", 3));
        listaPalabras.Add(new Palabra("musica", 2));
        listaPalabras.Add(new Palabra("ciudad", 3));
        listaPalabras.Add(new Palabra("mariposa", 3));
        listaPalabras.Add(new Palabra("reloj", 1));
        listaPalabras.Add(new Palabra("lluvia", 2));
        listaPalabras.Add(new Palabra("futbol", 1));
        listaPalabras.Add(new Palabra("chocolate", 3));
        listaPalabras.Add(new Palabra("bocadillo", 3));
        listaPalabras.Add(new Palabra("avioneta", 4));
        listaPalabras.Add(new Palabra("ordenador", 4));
        listaPalabras.Add(new Palabra("espacio", 3));
        listaPalabras.Add(new Palabra("planeta", 3));
        listaPalabras.Add(new Palabra("libro", 1));
        listaPalabras.Add(new Palabra("paraguas", 2));
        listaPalabras.Add(new Palabra("escritorio", 3));
        listaPalabras.Add(new Palabra("guitarra", 3));
        listaPalabras.Add(new Palabra("tren", 1));
        listaPalabras.Add(new Palabra("bicicleta", 2));
        listaPalabras.Add(new Palabra("camara", 2));
        listaPalabras.Add(new Palabra("fotografia", 4));
        listaPalabras.Add(new Palabra("jirafa", 3));
        listaPalabras.Add(new Palabra("pelicano", 3));
    }

    public void InicializarJuego(string usuario, int dificultad)
    {

    }

    private string CargarPalabra(int dificultad)
    {
        
    }
}