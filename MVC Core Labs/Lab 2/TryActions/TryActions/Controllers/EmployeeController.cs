using Microsoft.AspNetCore.Mvc;
using MVC.Model;
using System.Collections.Generic;
using System.Linq;

namespace TryActions.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> employess = new List<Employee>()
      {
          new Employee{Id=1,Name="Aya",Age=30,Salary=5000},
          new Employee{Id=2,Name="Khaled",Age=35,Salary=10000},
          new Employee{Id=3,Name="Omnya",Age=29,Salary=4000},
          new Employee{Id=4,Name="Alaa",Age=24,Salary=3000},
          new Employee{Id=5,Name="Muhamed",Age=26,Salary=5000},
          new Employee{Id=6,Name="Ahmed",Age=50,Salary=10000},
      };
        [HttpGet]
        public JsonResult GetEmployees()
        {
            return Json(employess);
        }
        [HttpPost]
        public void AddEmployee([FromBody]Employee Emp)
        {

            employess.Add(Emp);
        }
        [HttpPut]
        public void EditEmployee([FromBody] Employee Emp)
        {
            var editEmp = employess.FirstOrDefault(ww => ww.Id == Emp.Id);
            editEmp.Name = Emp.Name;
            editEmp.Age = Emp.Age;
            editEmp.Salary = Emp.Salary;
            
        }
        [HttpDelete]
        public void DeleteEmployee(int EmpId)
        {
            var emp = employess.FirstOrDefault(ww => ww.Id == EmpId);
            employess.Remove(emp);
        }
    }
}
