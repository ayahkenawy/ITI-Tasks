using FsCheck;
using Microsoft.EntityFrameworkCore;

namespace TryStateStatement.Models
{
    public class Context:DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ValidationTest;Trusted_Connection=true");
        }

    }
}
