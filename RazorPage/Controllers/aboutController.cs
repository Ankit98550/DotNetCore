using Microsoft.AspNetCore.Mvc;

namespace RazorPage.Controllers
{
    public class aboutController : Controller
    {
        [Route("")]
        [Route("About")]
        [Route("About/index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
