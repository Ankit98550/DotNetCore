using Microsoft.AspNetCore.Mvc;

namespace RazorPage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
