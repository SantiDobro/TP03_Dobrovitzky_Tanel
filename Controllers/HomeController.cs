using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03_Dobrovitzky_Tanel.Models;

namespace TP03_Dobrovitzky_Tanel.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Dictionary<int, Disco> discos = MusicStore.InicializarDiscos();
        ViewBag.discos = discos;
        return View();
    }
}
