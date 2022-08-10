using Microsoft.EntityFrameworkCore;
using StudentsCourses.Data.Models;

namespace StudentsCourses.Data.Context
{
    public class SchoolContext:DbContext
    {
        public DbSet<Student> Students =>Set<Student>();
        public DbSet<Course> Courses =>Set<Course>();
        public SchoolContext(DbContextOptions<SchoolContext> options):base(options) 
        {
             

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Student>()
        //        .HasData(new Student { });
        //}
    }
}
