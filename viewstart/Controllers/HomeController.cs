using Microsoft.AspNetCore.Mvc;

namespace viewstart.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
         public IActionResult About()
        {
            return View();
        }
         public IActionResult contact()
        {
            return View();
        }

    }
}
