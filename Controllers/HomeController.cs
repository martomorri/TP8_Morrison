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
    public Serie VerInfoSerie(int IdSerie)
    {
        return BDSeries.ListarSerieXID(IdSerie);
    }
    public List<string> VerActores(int IdSerie)
    {
        return BDSeries.ListarActores(IdSerie);
    }
    public List<Temporada> VerTemporadas(int IdSerie)
    {
        return BDSeries.ListarTemporadas(IdSerie);
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
