using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewImports.Models;

namespace ViewImports.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ id=1,age=21,Gender="male",name="kalu"},
                new Student(){ id=2,age=22,Gender="female",name="kamal"},
                new Student(){ id=3,age=23,Gender="male",name="kunal"},
                new Student(){ id=4,age=24,Gender="male",name="karan"},
                new Student(){ id=5,age=25,Gender="male",name="kanak"}
            };   
            return View(students);
        }

        public IActionResult Privacy()
        {
            return View();
        }  public IActionResult About()
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