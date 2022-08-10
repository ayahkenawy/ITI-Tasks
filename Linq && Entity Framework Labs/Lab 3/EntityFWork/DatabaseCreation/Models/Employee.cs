using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCreation.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }
        public decimal Salary { get; set; }
        public virtual Department Department { get; set; }
        public override string ToString()
        {
            return $"{Name} ,{Age} ,{Department.Name} ,{Salary}";
        }
    }
}
