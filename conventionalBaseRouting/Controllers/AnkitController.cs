using Microsoft.AspNetCore.Mvc;

namespace conventionalBaseRouting.Controllers
{
    public class AnkitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
        public int Details(int id)
        {
            return id;
        }
    }
}
