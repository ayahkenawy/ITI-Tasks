using Microsoft.EntityFrameworkCore;

namespace RazorPageCRUD.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    }
}
