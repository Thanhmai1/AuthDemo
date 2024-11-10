using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthDemo.Data
{
    public class AuthDBContext : IdentityDbContext<IdentityUser>
    {
        public AuthDBContext(DbContextOptions options) : base(options)
        {
        }
    }
}
