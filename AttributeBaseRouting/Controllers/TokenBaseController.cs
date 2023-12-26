using Microsoft.AspNetCore.Mvc;

namespace AttributeBaseRouting.Controllers
{
    [Route("[controller]")]
    public class TokenBaseController : Controller
    {
        [Route("")]
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("[action]/{id?}")]
        public int Details(int id)
        {
            return id;
        }
    }
}
