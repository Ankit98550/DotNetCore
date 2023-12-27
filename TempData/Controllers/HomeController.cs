using Microsoft.AspNetCore.Mvc;

namespace TempData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TempData["user"] = "Rohit";
            ViewData["user"] = "Rohit";
            ViewBag.user = "Rohit";
            TempData.Keep();
            return View();
        }public IActionResult contact()
        {
            return View();
        }public IActionResult about()
        {
            return View();
        }
    }
}
