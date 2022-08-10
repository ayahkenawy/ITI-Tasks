using StudentsCourses.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace StudentsCourses.DTOs.Students
{
    public class StudentWriteDTO
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public ICollection<Course> Courses = new HashSet<Course>();
    }
}
