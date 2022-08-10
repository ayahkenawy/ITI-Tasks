using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFWorkD3.Models
{

    public class Department
    {
        public int DepartmentId { get; set; }
        public string? DeptName { get; set; }
        public string? Description { get; set; }
        public DateTime? TimeStamp { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
            = new HashSet<Employee>();
    }
}
