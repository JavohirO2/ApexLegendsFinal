using Microsoft.AspNetCore.Mvc;

namespace ApexLegendsFinal.Models
{
    public class ApexViewModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
