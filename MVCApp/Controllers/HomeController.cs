using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers;

public class HomeController : Controller
{
    // private readonly ILogger variable
    private readonly ILogger<HomeController> _logger;

    // controller constructor initializes the logger
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // actions are the buttons we see on our page that we can click on in the navbar and they return a view of the page
    public IActionResult Index()
    {
        return View();
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
