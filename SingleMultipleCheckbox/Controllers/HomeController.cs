using Microsoft.AspNetCore.Mvc;
using SingleMultipleCheckbox.Models;
using System.Diagnostics;

namespace SingleMultipleCheckbox.Controllers
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
            var model = new ViewModel()
            {
                AcceptTerm = false,
                Text="I Agree"
            };

            return View(model);
        }
        [HttpPost]
       public IActionResult Index(ViewModel v)
        {
            var model = new ViewModel()
            {
                AcceptTerm = true,
                Text = "I Agree"
            };

            return View(model);
        }        

        public IActionResult  MultipleCheckbox() {

            var model = bind();
            return View(model);
        }

        private ViewModelCheckbox bind()
        {
            var model = new ViewModelCheckbox()
            {
                Options = new List<CheckboxOptions> {

                    new CheckboxOptions (){
                    check=true,
                    Text="Cricket",
                    Value="Cricket"
                    },
                    new CheckboxOptions (){
                    check=false,
                    Text= "FootBall",
                    Value="FootBall"
                    }, new CheckboxOptions (){
                    check=false,
                    Text= "chess",
                    Value="chess"
                    }, new CheckboxOptions (){
                    check=false,
                    Text= "Mesh",
                    Value="Mesh"
                    }
                }

            };
            return model;

        }

        [HttpPost]
        public IActionResult MultipleCheckbox(ViewModelCheckbox vc)
        {
            var model = bind();
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