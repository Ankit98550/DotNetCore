using Microsoft.AspNetCore.Mvc;

namespace AttributeBaseRouting.Controllers
{
    public class HomeController : Controller
    {

        //Attribute Routing 
        [Route("")]
        [Route("Ankit/Index")]
        public IActionResult Index()
        {
            return View();
        } 
        [Route("Ankit/Data/{id}")]
        public int Details(int id)
        {
            return id;
        }
    }
}
