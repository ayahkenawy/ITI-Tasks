using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFWorkD3.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Instuctor> Instuctors { get; set; }
            = new HashSet<Instuctor>();
        public virtual ICollection<Student_Course> StudentCourses { get; set; }
            = new HashSet<Student_Course>();
    }
}
