using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFWorkD3.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFWorkD3.Context
{
    public class ITIContext:DbContext
    {
        public ITIContext():base()
        {
            
        }

        public ITIContext(DbContextOptions options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Instuctor>()
                .HasKey(pk => pk.InsId);
            modelBuilder.Entity<Instuctor>()
                .HasAlternateKey(un => un.Email);
            modelBuilder.Entity<Instuctor>()
                .Property(na => na.Name)
                .IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Student_Course>()
                .HasKey(ww => new {ww.CourseId, ww.StudentId});
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies()
                .UseSqlServer("Server=.;Database=ITIDatabase;Trusted_Connection=true");

        }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Instuctor> Instuctors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student_Course> Students_courses { get; set; }
    }
}
