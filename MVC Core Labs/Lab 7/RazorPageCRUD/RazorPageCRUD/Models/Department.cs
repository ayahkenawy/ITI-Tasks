using System.ComponentModel.DataAnnotations;

namespace RazorPageCRUD.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public virtual HashSet<Employee> Employees { get; set; }
        = new HashSet<Employee>();
    }
}
