using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPageCRUD.Models;

namespace RazorPageCRUD.Pages.EmployeePages
{
    public class EditModel : PageModel
    {
        Context Db;
        public List<Department> departments { get; set; }
        [BindProperty]
        public Employee Employee { get; set; }
        public EditModel(Context _Db)
        {
            Db = _Db;
        }
        public void OnGet(int Id)
        {
            Employee = Db.Employees.Find(Id);
            departments = Db.Departments.ToList();
            ViewData["depts"] = new SelectList(departments, "DeptId", "DeptName");
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Db.Update(Employee);
                Db.SaveChanges();
                return RedirectToPage("/EmployeePages/Index");
            }

            departments = Db.Departments.ToList();
            ViewData["depts"] = new SelectList(departments, "DeptId", "DeptName");
            return RedirectToPage("Edit");

        }
    }
}
