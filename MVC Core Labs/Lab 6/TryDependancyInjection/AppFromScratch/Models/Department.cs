
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppFromScratch.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public ICollection<Employee> employees { get; set; } = new HashSet<Employee>();
    }
}
