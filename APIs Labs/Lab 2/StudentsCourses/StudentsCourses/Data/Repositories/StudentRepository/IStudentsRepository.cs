using StudentsCourses.Data.Models;
using StudentsCourses.Data.Repositories.GenericRepository;

namespace StudentsCourses.Data.Repositories.StudentRepository
{
    public interface IStudentsRepository:IGenericRepository<Student>
    {
        Student GetStudentByPhone(string phone);
        List<Student> GetAllWithCourses();

    }
}
