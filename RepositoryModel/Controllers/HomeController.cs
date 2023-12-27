using Microsoft.AspNetCore.Mvc;
using RepositoryModel.Models;
using RepositoryModel.Models.Repository;
using System.Diagnostics;

namespace RepositoryModel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private StudentRepository _studentRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _studentRepository= new StudentRepository();
            _logger = logger;
        }

        public List<Student>  GetStudents() { 
            return _studentRepository.GetStudents();    
        }
        public Student  GetStudentsbyId(int id) { 
            return _studentRepository.GetStudent(id);    
        }

        public IActionResult Index()
        {
            return View();
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