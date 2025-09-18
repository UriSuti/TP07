using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP07.Models;

namespace TP07.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Juego juego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("juego"));
        if (juego is null)
        {
            juego = new Juego();
            HttpContext.Session.SetString("juego", Objeto.ObjectToString<Juego>(juego));
        }
        List<Usuario> jugadoresYaCompitieron = juego.DevolverListaUsuarios();
        ViewBag.jugadoresYaCompitieron = jugadoresYaCompitieron;
        return View();
    }

    [HttpPost]
    public IActionResult Comenzar(string username, int dificultad)
    {
        Juego juego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("juego"));
        juego.InicializarJuego(username, dificultad);
        ViewBag.username = username;
        string palabra = juego.palabra;
        ViewBag.palabra = palabra;
        HttpContext.Session.SetString("juego", Objeto.ObjectToString<Juego>(juego));
        return View("Juego");
    }

    [HttpPost]
    public IActionResult FinJuego(int intentos)
    {
        Juego juego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("juego"));
        juego.FinJuego(intentos);
        HttpContext.Session.SetString("juego", Objeto.ObjectToString<Juego>(juego));
        return RedirectToAction("Index");
    }
}
