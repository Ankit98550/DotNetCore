using Microsoft.AspNetCore.Mvc;
using MultipleModelInSingleView.Models;
using System.Diagnostics;

namespace MultipleModelInSingleView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private List<Student> BindStudentData()
        {

            var students = new List<Student>() { 
            new Student{id=1,name="rohit",age=33,standard="12"},
            new Student{id=1,name="rohi1t",age=32,standard="12"},
            new Student{id=1,name="rohi2t",age=30,standard="12"},
            new Student{id=1,name="rohi3t",age=33,standard="12"},
            new Student{id=1,name="rohi4t",age=33,standard="12"}
            };
            return students;
        } private List<teacher> BindteachersData()
        {

            var teacher = new List<teacher>() { 
            new teacher{id=1,name="Teacher_rohit",age=33,Des="12"},
            new teacher{id=1,name="Teacher_rohi1t",age=32,Des="12"},
            new teacher{id=1,name="Teacher_rohi2t",age=30,Des="12"},
            new teacher{id=1,name="Teacher_rohi3t",age=33,Des="12"},
            new teacher{id=1,name="Teacher_rohi4t",age=33,Des="12"}
            };
            return teacher;
        }


        public IActionResult Index()
        {
            var srudents=BindStudentData();
           // var srudents = new List<Student>();
            var teaches = BindteachersData();
            var model= new SchoolModel(){
                Students = srudents,
                teachers = teaches
            };
            return View(model);
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