using System.ComponentModel.DataAnnotations;

namespace StudentsCourses.Data.Models
{
    public class Student
    {
        [Key ]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Grade { get; set; } 
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
