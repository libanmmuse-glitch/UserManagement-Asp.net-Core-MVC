using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserManagement.Models;

namespace UserManagement.Data
{
    public class AppDbContext:IdentityDbContext<Users>
    {
        public AppDbContext(DbContextOptions options) :base(options) 
        {
            
        }
    }
}
