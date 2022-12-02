using ApexLegendsFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ApexLegendsFinal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Legends()
        {
            return View();
        }

        public IActionResult Weapons()
        {
            return View();
        }

        public IActionResult Maps()
        {
            return View();
        }

        public IActionResult Ranked()
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