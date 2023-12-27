using Microsoft.AspNetCore.Mvc;

namespace viewBag.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.user = "Rohit";
            ViewBag.count = 1;
            string[] t = { "john","kalu","malu","tonny"};
            ViewBag.data = t;
            ViewBag.fruits=new List<string>() { "oriange","mango","grpes"};
            ViewData["fruits"]=new List<string>() { "oriange","mango","grpes"};

            return View();
        }
    }
}
