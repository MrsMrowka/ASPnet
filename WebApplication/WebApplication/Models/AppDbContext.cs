using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace WebApplication.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Product>Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) 
        { 
        
        }

    }
}
