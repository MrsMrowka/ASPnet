using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public static class IdentitySeedData
    {
        private const string adminUser = "Admin";
        private const string adminPassword = "Test1234";
        public static async Task EnsurePopulated(IApplicationBuilder app)
        {
            UserManager<IdentityUser> userManager = app.ApplicationServices.GetRequiredService<UserManager<IdentityUser>>();

            IdentityUser user = await userManager.FindByNameAsync(adminUser);
            if (user == null)
            {
                user = new IdentityUser("Admin");
                await userManager.CreateAsync(user, adminPassword);
            }
        }

    }
}
