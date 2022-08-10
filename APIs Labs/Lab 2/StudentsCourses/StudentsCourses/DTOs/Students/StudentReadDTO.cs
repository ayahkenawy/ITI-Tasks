using StudentsCourses.Data.Models;
using StudentsCourses.DTOs.Courses;

namespace StudentsCourses.DTOs.Students
{
    public class StudentReadDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public ICollection<CourseChildReadDTO> Courses { get; set; } = new HashSet<CourseChildReadDTO>();
    }
}
