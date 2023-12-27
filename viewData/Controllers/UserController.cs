using Microsoft.AspNetCore.Mvc;

namespace viewData.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            //viewData use for store data 
            //we need convert 
            ViewData["User"] ="Rohit";
            ViewData["UserCount"] =1;
            string[] r = { "ankit", "Rohit", "Mohit", "kumar" };
            ViewData["data"] =r;
            ViewData["game"] =new List<String>() { 
            "cricket","football","chess"
            };

            return View();
        }
    }
}
