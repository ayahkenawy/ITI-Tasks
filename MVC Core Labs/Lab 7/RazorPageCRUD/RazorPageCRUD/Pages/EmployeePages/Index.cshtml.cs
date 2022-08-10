using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageCRUD.Models;

namespace RazorPageCRUD.Pages.EmployeePages
{
    public class IndexModel : PageModel
    {
        Context Db;
        public List<Employee> Employees { get; set; }
        public IndexModel(Context _Db)
        {
            Db = _Db;
        }
        public void OnGet()
        {
            Employees = Db.Employees.Include(ww=>ww.Department).ToList();
        }
        public IActionResult OnGetDelete(int Id)
        {
            var emp = Db.Employees.FirstOrDefault(ww=>ww.Id== Id);
            Db.Remove(emp);
            Db.SaveChanges();
            return RedirectToPage("Index");
            
        }
    }
}
