using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentsCourses.Data.Context;
using StudentsCourses.Data.Models;
using StudentsCourses.Data.Repositories.CourseRepository;
using StudentsCourses.Data.Repositories.GenericRepository;
using StudentsCourses.Data.Repositories.StudentRepository;
using StudentsCourses.DTOs.Courses;
using StudentsCourses.DTOs.Students;

namespace StudentsCourses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentsRepository _studentsRepository;
        private readonly IGenericRepository<Course> _courseRepository;
        private readonly IMapper _mapper;

        public StudentsController(IStudentsRepository studentsRepository,IMapper mapper, IGenericRepository<Course> courseRepository)
        {
            _studentsRepository = studentsRepository;
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        // GET: api/Students
        [HttpGet]
        public ActionResult<IEnumerable<StudentReadDTO>> GetStudents()
        {

            var studentList = _studentsRepository.GetAll();
            return _mapper.Map<List<StudentReadDTO>>(studentList);
        }

        // GET: api/Students/5
        [HttpGet("{id}")]
        public ActionResult<StudentReadDTO> GetStudent(Guid id)
        {
            var student = _studentsRepository.GetById(id);
            if (student is null)
            {
                return NotFound();
            }
            var studentToRead = _mapper.Map<StudentReadDTO>(student);
            return studentToRead;
        }

        // PUT: api/Students/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutStudent(Guid id,[FromBody] StudentWriteDTO student)
        {
            if (id != student.Id)
            {
                return BadRequest();
            }
            var editStudent = _studentsRepository.GetById(id);
            if (editStudent is null)
            {
                return NotFound();
            }
            _mapper.Map(student,editStudent);
            _studentsRepository.SaveChanges();
            return NoContent();
        }

        // POST: api/Students
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<Student> PostStudent([FromBody]StudentWriteDTO student)
        {
            var studentToAdd = _mapper.Map<Student>(student);

            _studentsRepository.Add(studentToAdd);
            _studentsRepository.SaveChanges();

            return CreatedAtAction("GetStudent", new { id = student.Id }, student);
        }

        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public  IActionResult DeleteStudent(Guid id)
        {
            var student = _studentsRepository.GetById(id);
            if (student is null)
            {
                return NotFound();
            }
            _studentsRepository.Delete(student);
            _studentsRepository.SaveChanges();

            return NoContent();
        }
        [HttpGet("{phone}")]
        public ActionResult<Student> GetByPhone(string phone)
        {
            var student = _studentsRepository.GetStudentByPhone(phone);
            if (student is null)
            {
                return NotFound();
            }

            return student;
        }
        [HttpPost]
        [Route("CoursesToStudent")]
        public ActionResult AssignIssuesToPatient(CoursesToStudentDTO dto)
        {
            var student = _studentsRepository.GetAllWithCourses().FirstOrDefault(p => p.Id == dto.StudentId);
            var CoursesRequiredFromClient = _courseRepository.GetAll().Where(i => dto.CoursesIds.Contains(i.Id))
                .ToList();
            if (student == null)
            {
                return NotFound();
            }
            student.Courses = CoursesRequiredFromClient;
            _studentsRepository.SaveChanges();
            return Ok();
        }
    }
}
