using CargoOperatingSystem.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CargoOperatingSystem.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            builder.HasData(
                
                new ApplicationUser {
                Id = "b3bc7e01-778b-400a-a7f6-3289c681d304",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                
                new ApplicationUser {
                Id = "b3bc7e01-778b-400a-a7f6-3289c681d405",
                Email = "test@test.cz",
                NormalizedEmail = "TEST@TEST.CZ",
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                UserName = "test@test.cz",
                NormalizedUserName = "TEST@TEST.CZ",
                PasswordHash = hasher.HashPassword(null, "P@ssword1")
                });
        }
    }
}
