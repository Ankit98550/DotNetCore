using Microsoft.AspNetCore.Mvc;

namespace layout.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("/")]
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        } 
        [Route("[action]")]
        public IActionResult about()
        {
            return View();
        }
        [Route("[action]")]
        public IActionResult contact()
        {
            return View();
        }
    }
}
