using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TryStateStatement.Models
{
    public class Employee
    {
        [Required]
        [Display(Name ="SSN")]
        public int Id { get; set; }
        [Required(ErrorMessage ="Required Please Enter First Name")]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string Fname { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string Lname { get; set; }
        [Required]
        [Range(18,60)]
        public int Age { get; set; }
        [DataType(DataType.Currency)]
        [Range(2000,10000)]
        public decimal Salary { get; set; }
        [DataType(DataType.MultilineText)]
        public string? Address { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [NotMapped]
        public string ConPassword { get; set; }
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime?  BirthDate {get;set;}
        [DataType(DataType.Url)]
        [Url]
        [Display(Name = "FB URL")]
        public string Url { get; set; }
        
        [ForeignKey("Department")]
        public int? DeptId { get; set; }
        public virtual Department Department { get; set; }
    }
}
