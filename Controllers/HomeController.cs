using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP8_Morrison.Models;

namespace TP8_Morrison.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.ListaSeries = BDSeries.ListarSeries();
        return View();
    }
    public List<string> VerActores(int IdSerie)
    {
        List<string> ListaActores = BDSeries.ListarActores(IdSerie);
        return ListaActores;
    }
    public List<Temporada> VerTemporadas(int IdSerie)
    {
        List<Temporada> ListaTemporadas = BDSeries.ListarTemporadas(IdSerie);
        return ListaTemporadas;
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
