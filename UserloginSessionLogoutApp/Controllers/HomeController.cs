using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UserloginSessionLogoutApp.Models;

namespace UserloginSessionLogoutApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public UsertblContext Context { get; }

        public HomeController(ILogger<HomeController> logger,UsertblContext context)
        {
            _logger = logger;
            Context = context;
        }

        public IActionResult Index()
        {
            var gender = Enums.Data();
            ViewBag.Gender = gender;
           var r= Context.Users.ToList();
            return View(r);
        }
        public IActionResult Details( int id)
        {
            var r = Context.Users.FirstOrDefault(x=>x.Id==id);
            return View(r);
        } public IActionResult Edit( int id)
        {
            var r = Context.Users.FirstOrDefault(x=>x.Id==id);
            return View(r);
        }public IActionResult Delete( int id)
        {
            var r = Context.Users.FirstOrDefault(x=>x.Id==id);
            return View(r);
        }
        [HttpPost]
        public IActionResult Edit( int id,User user)
        {
           if(ModelState.IsValid)
            {
                Context.Users.Update(user); 
                Context.SaveChanges();  
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult register(User user)
        {
            if (ModelState.IsValid)
            {
                Context.Users.Add(user);
                Context.SaveChanges();
                ViewBag.suc = "Register SuccessFully";
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.fail = "Register Failed";

            }
            return View();
        } public IActionResult register()
        {
            var gender = Enums.Data();
            ViewBag.Gender = gender;
            return View();
        }

        [HttpPost ,ActionName("Delete")]
        public IActionResult deleteConfirm(int id )
        {
           if(ModelState.IsValid)
            {
               var user = Context.Users.FirstOrDefault(x => x.Id == id);
                Context.Users.Remove(user);
                Context.SaveChanges();  
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult login()
        {
            if (HttpContext.Session.GetString("Email") != null)
            {
                return RedirectToAction("Dashboard");
            }

                return View();  
        }public IActionResult logout()
        {
            if (HttpContext.Session.GetString("Email") != null)
            {
                HttpContext.Session.Remove("Email");
                HttpContext.Session.Remove("name");
                return RedirectToAction("login");
            }
            return RedirectToAction("login");  
        }
        [HttpPost]
        public IActionResult login(User user)
        {
           
                var data = Context.Users.Where(x => x.Email == user.Email && x.Password==user.Password);
                if(data.Any())
                {
                    var name =data.First().Name;
                    ViewBag.Email = user.Email;
                    HttpContext.Session.SetString("Email",user.Email);
                    HttpContext.Session.SetString("name",name);
                    return RedirectToAction("Dashboard");
                }
                else
                {
                    ViewBag.Message = "Login Fail";
                }
            
            return View();  
        }

        public IActionResult Dashboard()
        { 
            if (HttpContext.Session.GetString("Email")!=null)
            {
                TempData["Name"] = HttpContext.Session.GetString("name");

                return View();
            }else
                return RedirectToAction("login");

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