using StudentsCourses.Data.Context;
using StudentsCourses.Data.Models;
using StudentsCourses.Data.Repositories.GenericRepository;

namespace StudentsCourses.Data.Repositories.CourseRepository
{
    public class CourseRepository : GenericRepository<Course>
    {
        public readonly SchoolContext _context;
        public CourseRepository(SchoolContext context) : base(context)
        {
            _context = context;
        }
       
    }
}
