using System.ComponentModel.DataAnnotations;

namespace MvcAuth.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? ExtraInfo { get; set; }
    }
}
