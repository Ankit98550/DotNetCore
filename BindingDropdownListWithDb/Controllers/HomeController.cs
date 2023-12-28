using BindingDropdownListWithDb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace BindingDropdownListWithDb.Controllers
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
            var student = bindDDl();

            return View(student);
        }
        [HttpPost]
        public IActionResult Index(StudentModel model)
        {
            var student = Context.Students.Where(x=>x.Id== model.Id).FirstOrDefault();
            if(student != null)
            {
                ViewBag.Selectvalue = student.StudentName;  

            }
            var mystudent = bindDDl();
            return View(mystudent);
        }

        private StudentModel bindDDl()
        {
            StudentModel student = new StudentModel();
            student.studentList = new List<SelectListItem>();
            var data = Context.Students.ToList();

            student.studentList.Add(
                 new SelectListItem
                 {
                     Text = "Select Name",
                     Value = "",

                 }
                );

            foreach (var item in data)
            {
                student.studentList.Add(
                    new SelectListItem
                    {
                        Text = item.StudentName,
                        Value = item.Id.ToString(),

                    }
                    );
            }
            return student;

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