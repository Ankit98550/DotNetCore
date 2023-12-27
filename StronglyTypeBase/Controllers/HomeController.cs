using Microsoft.AspNetCore.Mvc;
using StronglyTypeBase.Models;
using System.Diagnostics;

namespace StronglyTypeBase.Controllers
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
            //Employee employee= new Employee() { 
            //EmpId = 1,
            //name ="Rohit",
            //Des="Manager",
            //salary=2200
            //};
            List<Employee> employee = new List<Employee>() { 
            new Employee() {EmpId = 1,name="Rohit",salary=2000,Des="Manger"},
            new Employee() {EmpId = 2,name="Mohit",salary=2000,Des="Sales Manger"},
            new Employee() {EmpId = 3,name="Rakesh",salary=2000,Des="Rep"},
            new Employee() {EmpId = 4,name="Tony",salary=2000,Des="Distribute"}
            };
            return View(employee);
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