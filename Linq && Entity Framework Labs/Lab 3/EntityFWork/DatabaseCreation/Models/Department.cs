using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCreation.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public DateTime? TimeStamp { get; set; }
        public virtual ICollection<Employee> Employees { get; set; } 
            = new HashSet<Employee>();

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
