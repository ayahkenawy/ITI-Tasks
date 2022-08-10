using Microsoft.EntityFrameworkCore;
using StudentsCourses.Data.Context;
using StudentsCourses.Data.Models;
using StudentsCourses.Data.Repositories.GenericRepository;

namespace StudentsCourses.Data.Repositories.StudentRepository
{
    public class StudentsRepository : GenericRepository<Student>, IStudentsRepository
    {
        public readonly SchoolContext _context;
        public StudentsRepository(SchoolContext context) : base(context)
        {
            _context = context;
        }
        public Student GetStudentByPhone(string phone)
        {
            return (Student)_context.Students.Where(w => w.Phone == phone);
        }
        public List<Student> GetAllWithCourses()
        {
            return _context.Students.Include(c=>c.Courses).ToList();
        }
    }
}
