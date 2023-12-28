using Microsoft.AspNetCore.Mvc;
using StronglyTypePartialView.Models;
using System.Diagnostics;

namespace StronglyTypePartialView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private List<Product> BindProductData()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1,Name="Car",Description="new",price=90,img="~/img/r1.jpeg"},
                new Product { Id = 2,Name="jeep",Description="new",price=90,img="~/img/r2.jpeg"},
                new Product { Id = 3,Name="thar",Description="new",price=90,img="~/img/r3.jpeg"},
                new Product { Id = 4,Name="ody",Description="new",price=90,img="~/img/PHOTO.jpeg"},
                new Product { Id = 5,Name="mar",Description="new",price=90,img="~/img/thumb .jpg"}
            };   
            return products;
        }

        public IActionResult Index()
        {
            return View();
        }public IActionResult product()
        {
            var products = BindProductData();
            return View(products);
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