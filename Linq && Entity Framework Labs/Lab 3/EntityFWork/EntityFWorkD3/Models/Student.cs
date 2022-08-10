using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFWorkD3.Models
{
    //[Table("Std")]
    public class Student
    {   [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ssn { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        //[Range(18,60)]
        public int? Age { get; set; }
        public string Address { get; set; }
        [Column("DateOfBirth",TypeName = "date")]
        public DateTime DOB { get; set; }
        [Required]
        public string Email { get; set; }
        [Column("StdExpenses",TypeName = "money")]

        public decimal Price { get; set; }
        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Student_Course> StudentCourses { get; set; }
            = new HashSet<Student_Course>();

    }
}
