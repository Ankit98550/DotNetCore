using Microsoft.AspNetCore.Mvc;

namespace ActionResultProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ContentResult content()
        {
            return  Content("new Data");
        }

        public JsonResult JsonResult()
        {
            return Json(new { data="ankit" });
        }
    }
}
