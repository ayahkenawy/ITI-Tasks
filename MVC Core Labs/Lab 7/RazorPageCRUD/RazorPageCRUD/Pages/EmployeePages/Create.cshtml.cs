using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPageCRUD.Models;

namespace RazorPageCRUD.Pages.EmployeePages
{
    public class CreateModel : PageModel
    {
        Context Db;
        public List<Department> departments { get; set; }
        [BindProperty]
        public Employee Employee { get; set; }
        public CreateModel(Context _Db)
        {
            Db = _Db;
        }
        public void OnGet()
        {
            departments =Db.Departments.ToList();
            ViewData["depts"] = new SelectList(departments, "DeptId", "DeptName");
        }
        public IActionResult OnPost()
        {
            Db.Add(Employee);
            Db.SaveChanges();
            return RedirectToPage("/EmployeePages/Index");
        }
    }
}
