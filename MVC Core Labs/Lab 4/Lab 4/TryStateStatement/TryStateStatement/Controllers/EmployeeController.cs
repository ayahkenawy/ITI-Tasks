using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TryStateStatement.Models;

namespace TryStateStatement.Controllers
{
    public class EmployeeController : Controller
    {
        Context Db = new Context();
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SaveEmp(Employee Emp)
        {
            Db.Employees.Add(Emp);
            Db.SaveChanges();
            return View();
        }
        [HttpPost]
        public IActionResult SaveEmpPost(Employee Emp)
        {
            Db.Employees.Add(Emp);
            Db.SaveChanges();
            return View();
        }
        public IActionResult GetEmployees()
        {
            var Emps = Db.Employees.Include(ww => ww.Department).ToList();
            return View(Emps);
        }
        public IActionResult GetEmployee(int Id)
        {
            var Emp = Db.Employees.Include(ww => ww.Department).SingleOrDefault(ww => ww.Id == Id);
            if (Emp == null)
                return View("/Error");
            else
            {
                return View(Emp);
            }

        }
        public IActionResult TryView()
        {
            var Emps = Db.Employees.Include(ww => ww.Department).ToList();
            ViewBag.Emp = Emps;

            ViewData["Emp"] = Emps;
            TempData["Emp"] = Emps;

            return View();
        } 
    }
}
