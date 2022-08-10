namespace StudentsCourses.Data.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Grade { get; set; }
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
