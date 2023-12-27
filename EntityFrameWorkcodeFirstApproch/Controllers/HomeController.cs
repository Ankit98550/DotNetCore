using EntityFrameWorkcodeFirstApproch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EntityFrameWorkcodeFirstApproch.Controllers
{
    public class HomeController : Controller
    {
        public StudentDbContext StudentData { get; }

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(StudentDbContext student) {
            this.StudentData = student;
        }

        public IActionResult Index()
        {
            var std = StudentData.Students.ToList();
            return View(std);
        } 
        public async Task<IActionResult> Details(int? id)
        {
            //var std = StudentData.Students.Where(x=>x.id == id).FirstOrDefault();
            var std = StudentData.Students.FirstOrDefault(x=>x.id==id);
            return View(std);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            //var std = StudentData.Students.Where(x=>x.id == id).FirstOrDefault();
            var std = StudentData.Students.FirstOrDefault(x => x.id == id);

            return View(std);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,student stdent)
        {
            if (ModelState.IsValid)
            {
                StudentData.Students.Update(stdent);
                await StudentData.SaveChangesAsync();
                TempData["edit"] = true;
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var s=await StudentData.Students.FirstOrDefaultAsync(x=>x.id==id);
            return View(s);
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var s=await StudentData.Students.FindAsync(id);
            if (s != null)
            {
                StudentData.Students.Remove(s);
            await StudentData.SaveChangesAsync();
                TempData["del"] = true;
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        //public IActionResult create(student std)
        //{
        //    if(ModelState.IsValid)
        //    {
        //     StudentData.Students.Add(std);
        //        StudentData.SaveChanges();
        //        return RedirectToAction("Index","Home");
        //    }
        //    return View();
        //} 
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> create(student std)
        {
            if (ModelState.IsValid)
            {
               await StudentData.Students.AddAsync(std);
               await StudentData.SaveChangesAsync();
                TempData["sucesss"] = true;
                return RedirectToAction("Index", "Home");
            }
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