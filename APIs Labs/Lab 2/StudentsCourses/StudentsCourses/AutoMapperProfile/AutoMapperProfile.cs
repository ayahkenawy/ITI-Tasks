using AutoMapper;
using StudentsCourses.Data.Models;
using StudentsCourses.DTOs.Courses;
using StudentsCourses.DTOs.Students;

namespace StudentsCourses.AutoMapperProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Student, StudentReadDTO>();
            CreateMap<StudentWriteDTO, Student > ();
            CreateMap<Course, CourseChildReadDTO>();

        }

    }
}
