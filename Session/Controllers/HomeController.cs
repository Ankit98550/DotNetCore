﻿using Microsoft.AspNetCore.Mvc;
using Session.Models;
using System.Diagnostics;

namespace Session.Controllers
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
            HttpContext.Session.SetString("user", "Rohit");

            return View();
        }

        public IActionResult Privacy()
        {
            var getsession= HttpContext.Session.GetString("user");
            TempData["user"]=getsession;
            TempData.Keep();
            return View();
        } public IActionResult About()
        {
            return View();
        } public IActionResult DirectAccessInView()
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