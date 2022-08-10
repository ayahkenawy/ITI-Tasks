using AppFromScratch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AppFromScratch.Controllers
{
    public class EmployeeController : Controller
    {
        Context Db;
        public EmployeeController(Context _db)
        {
            Db=_db;
        }
        public IActionResult Index()
        {
            var emps = Db.Employees.Include(ww => ww.Department).ToList();
            return View(emps);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.depts = new SelectList(Db.Departments.ToList(), "DeptId", "DeptName");
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var emp = Db.Employees.Find(id);
            ViewBag.depts = new SelectList(Db.Departments.ToList(), "DeptId", "DeptName", emp.DeptId);
            return View(emp);
        }
    }
}
