using Microsoft.AspNetCore.Identity;

namespace Auth.Data
{
    public class Employee:IdentityUser 
    {
        public string? Department { get; set; } 
    }
}
 