namespace CargoOperatingSystem.Server.Data
{
    using System;
    using System.Linq;
    using Microsoft.AspNetCore.Identity;
    using CargoOperatingSystem.Server.Models;

    public static class ApplicationDbInitialiser
    {
        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            AddRoleIfNotExists(roleManager, "Administrator");
            AddRoleIfNotExists(roleManager, "CargopointUser");
            AddRoleIfNotExists(roleManager, "CustomerUser");
        }
        public static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            (string username, string firstname, string lastname, string company, string password, string role)[] demoUsers = new[]
            {
                (username: "admin@cargopoint.com", firstname:"Ondrej", lastname:"Kozak", company: "Cargopoint", password: "Passw0rd!", role: "Administrator"),
                (username: "tomas@cargopoint.com", firstname:"Tomas", lastname:"Hajek", company: "Cargopoint", password: "Passw0rd!", role: "CargopointUser"),
                (username: "petr@expeditors.com", firstname:"Petr", lastname:"Novak", company: "Expeditors", password: "Passw0rd!", role: "CustomerUser"),
                (username: "karel@schenker.com", firstname:"Karel", lastname:"Pospisil", company: "Schenker", password: "Passw0rd!", role: "CustomerUser"),
                (username: "linda@ats.com", firstname:"Linda", lastname:"Majerova", company: "Ats", password: "Passw0rd!", role: "")
            };

            foreach ((string username, string firstname, string lastname, string company, string password, string role) user in demoUsers)
            {
                AddUserIfNotExists(userManager, user);
            }

        }

        private static void AddUserIfNotExists(UserManager<ApplicationUser> userManager, (string username, string firstname, string lastname, string company, string password, string role) demoUser)
        {
            ApplicationUser user = userManager.FindByNameAsync(demoUser.username).Result;
            if (user == default)
            {
                var newAppUser = new ApplicationUser
                {
                    UserName = demoUser.username,
                    Company = demoUser.company,
                    Email = demoUser.username,
                    FirstName = demoUser.firstname,
                    LastName = demoUser.lastname,
                    EmailConfirmed = true
                };
                _ = userManager.CreateAsync(newAppUser, demoUser.password).Result;
                if (!string.IsNullOrWhiteSpace(demoUser.role))
                {
                    var roles = demoUser.role.Split(',').Select(a => a.Trim()).ToArray();
                    Console.WriteLine($"{roles.Length}");
                    foreach (var role in roles)
                    {
                        _ = userManager.AddToRoleAsync(newAppUser, role).Result;

                    }
                }

            }
        }

        private static void AddRoleIfNotExists(RoleManager<IdentityRole> roleManager, string roleName)
        {
            if (roleManager.FindByNameAsync(roleName).Result == default)
            {
                roleManager.CreateAsync(new IdentityRole { Name = roleName }).Wait();
            }
        }
    }
}
