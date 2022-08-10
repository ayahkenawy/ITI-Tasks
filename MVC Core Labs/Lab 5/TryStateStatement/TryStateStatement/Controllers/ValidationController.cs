using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TryStateStatement.Models;

namespace TryStateStatement.Controllers
{
    public class ValidationController : Controller
    {
        Context Db = new Context();
        public IActionResult Index()
        {
            var Emps = Db.Employees.Include(ww => ww.Department).ToList();
            return View(Emps);
        }
        [HttpGet]
        public IActionResult Register()
        {
            var depts = Db.Departments.ToList();
            ViewBag.depts = new SelectList(depts, "DeptId", "DeptName", 1);
            return View();
        }
        [HttpPost]
        public IActionResult Register([FromForm] Employee Emp)
        {
            if (ModelState.IsValid)
            {
                Db.Add(Emp);
                Db.SaveChanges();
                return Redirect("Index");
            }
            else
            {
                var depts = Db.Departments.ToList();
                ViewBag.depts = new SelectList(depts, "DeptId", "DeptName", 1);
                return View();
            }


        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var emp = Db.Employees.Find(Id);
            var depts = Db.Departments.ToList();
            ViewBag.depts = new SelectList(depts, "DeptId", "DeptName", emp.DeptId);
            return View(emp);
        }
        [HttpPost]
        [ActionName("Edit")]
        public IActionResult Edit(Employee Emp)
        {
            if (ModelState.IsValid)
            {
                Db.Update(Emp);
                Db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                var depts = Db.Departments.ToList();
                ViewBag.depts = new SelectList(depts, "DeptId", "DeptName", Emp.DeptId);
                return View(Emp);
            }

        }
    }
}
