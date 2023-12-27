using Microsoft.AspNetCore.Mvc;

namespace BootstrapTailwainJqueryInstall.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
