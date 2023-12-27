using Microsoft.AspNetCore.Mvc;
using models.Models;

namespace models.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<student> students = new List<student>()
            {
                new student() {name="Rohit",standard="2nd",rollno=3,age=22},
                new student() {name="ankit",standard="2nd",rollno=3,age=22},
                new student() {name="mohit",standard="2nd",rollno=3,age=22},
                new student() {name="johtdfd",standard="2nd",rollno=3,age=22}
            };
            ViewBag.students = students;    
            return View();
        }
    }
}
