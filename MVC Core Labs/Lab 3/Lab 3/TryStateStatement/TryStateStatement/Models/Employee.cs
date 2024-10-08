﻿using System.ComponentModel.DataAnnotations.Schema;

namespace TryStateStatement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public decimal? Salary { get; set; }
        public string Address { get; set; }
        [ForeignKey("Department")]
        public int? DeptId { get; set; }
        public virtual Department Department { get; set; }
    }
}
