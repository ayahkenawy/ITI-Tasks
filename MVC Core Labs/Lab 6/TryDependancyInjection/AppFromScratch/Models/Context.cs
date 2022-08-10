using Microsoft.EntityFrameworkCore;

namespace AppFromScratch.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options ):base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
