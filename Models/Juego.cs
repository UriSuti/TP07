using Newtonsoft.Json;
namespace TP07.Models;

public class Juego
{
    [JsonProperty]
    private List<Palabra> listaPalabras;
    [JsonProperty]
    private List<Usuario> jugadores;
    [JsonProperty]
    private Usuario jugadorActual;
    public string palabra { get; private set; }

    public Juego()
    {
        listaPalabras = new List<Palabra>();
        jugadores = new List<Usuario>();
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
        llenarListaPalabras();
        jugadorActual = new Usuario(usuario, 0);
        palabra = CargarPalabra(dificultad);
    }

    private string CargarPalabra(int dificultad)
    {
        Random random = new Random();
        do
        {
            int indice = random.Next(listaPalabras.Count);
            if (listaPalabras[indice].dificultad == dificultad)
            {
                return listaPalabras[indice].texto;
            }
        } while (true);
    }

    public void FinJuego(int intentos)
    {
        jugadores.Add(new Usuario(jugadorActual.nombre, intentos));
    }

    public List<Usuario> DevolverListaUsuarios()
    {
        int n = jugadores.Count;

        if (n == 0)
        {
            return jugadores;
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (jugadores[j].cantidadIntentos > jugadores[j + 1].cantidadIntentos)
                {
                    Usuario usu = jugadores[j];
                    jugadores[j] = jugadores[j + 1];
                    jugadores[j + 1] = usu;
                }
            }
        }

        return jugadores;
    }
}