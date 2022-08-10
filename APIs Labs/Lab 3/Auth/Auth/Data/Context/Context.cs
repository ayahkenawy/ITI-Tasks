using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Auth.Data.Context
{
    public class Context:IdentityDbContext<Employee>
    {
        public Context(DbContextOptions<Context> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Employee>().ToTable("Employees");
            builder.Entity<IdentityUserClaim<string>>().ToTable("EmployeesClaims");
        }
    }
}
