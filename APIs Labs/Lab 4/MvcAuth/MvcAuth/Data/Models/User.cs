using Microsoft.AspNetCore.Identity;

namespace MvcAuth.Data.Models
{
    public class User:IdentityUser
    {
        public string? ExtrInfo { get; set; }
    }
}
