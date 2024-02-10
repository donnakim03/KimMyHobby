using KimMyHobby.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

/*
 * Donna Kim
 * Section 03
 * This is an ASP.NET Webpage about my hobby.
 */
namespace KimMyHobby.Controllers
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
            return View();
        }

        public IActionResult Calculator()
        {
            return View(); // For calculator view routing
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
