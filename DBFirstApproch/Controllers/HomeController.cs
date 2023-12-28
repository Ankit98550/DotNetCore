using DBFirstApproch.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DBFirstApproch.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public Test1Context Context { get; }

        public HomeController(ILogger<HomeController> logger,Test1Context context) 
        {
            _logger = logger;
            Context = context;
        }

        public IActionResult Index()
        {
            var data=Context.Employees.ToList();
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}