using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MvcAuth.Data.Context
{
    public class AuthContext:IdentityDbContext
    {
        public AuthContext(DbContextOptions options):base(options)
        {

        }
    }
}
