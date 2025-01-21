using System.Diagnostics;
using DesignPattern.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            /*
                We have 3 types of design patterns:
                1. Creational Design Patterns
                2. Structural Design Patterns
                3. Behavioral Design Patterns

             */
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
}
