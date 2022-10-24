using FairyGruppProjekt.Models;
using Microsoft.AspNetCore.Identity;

namespace FairyGruppProjekt
{
    public static class SeedData
    {
        public static void Seed(UserManager<AppUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        private static void SeedUsers(UserManager<AppUser> userManager)
        {
            if (userManager.FindByNameAsync("Admin").Result==null)
            {
                var user = new AppUser()
                {
                    UserName = "Admin",
                    Email = "Admin@localhost"
                };
                var result = userManager.CreateAsync(user, "@Dmin123").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }
            }
        }

        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                var role = new IdentityRole()
                {
                    Name = "Administrator"
                };
                roleManager.CreateAsync(role); //does this need wait for async or no?

            }

            if (!roleManager.RoleExistsAsync("Customer").Result)
            {
                var role = new IdentityRole()
                {
                    Name = "Customer"
                };
                roleManager.CreateAsync(role); //does this need wait for async or no?

            }
        }


    }
}
