using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TryStateStatement.Models;

namespace TryStateStatement.Controllers
{
    public class HomeController : Controller
    { 
        Context Db = new Context();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
       
        [HttpGet]
        public IActionResult Index()
        {
            var Emps = Db.Employees.Include(ww => ww.Department).ToList();
            return View(Emps);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register([FromForm]Employee Emp)
        {
            Db.Employees.Add(Emp);
            Db.SaveChanges();
            return Redirect("Index");
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var emp = Db.Employees.Find(Id);
            return View(emp);
        }
        [HttpPost]
        [ActionName("Edit")]
        public IActionResult Edit(Employee Emp)
        {
            Db.Update(Emp);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult View(int Id)
        {
            var emp = Db.Employees.Include(ww=>ww.Department).FirstOrDefault(id=>id.Id==Id);
            return View(emp);
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var emp = Db.Employees.Find(Id);
            Db.Remove(emp);
            Db.SaveChanges();
            return Redirect("Index");

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
