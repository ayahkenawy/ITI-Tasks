using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseCreation.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCreation.Context
{
    public class CompanyContext:DbContext
    {
        public CompanyContext():base()
        {
            
        }

        public CompanyContext(DbContextOptions options):base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.;Database=EmployeeDepart;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Department { get; set; }
    }
}
