using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFWorkD3.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public string Email { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public virtual Car Car { get; set; }
        public override string ToString()
        {
            return $"{Id}:{Name}:{Age}:{Email}:{Salary}:{DepartmentId}:{Department}";
        }
    }
}
