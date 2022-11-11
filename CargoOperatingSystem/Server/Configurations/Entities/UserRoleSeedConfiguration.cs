using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CargoOperatingSystem.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                    UserId = "b3bc7e01-778b-400a-a7f6-3289c681d304"
                },

                new IdentityUserRole<string>
                {
                    RoleId = "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                    UserId = "b3bc7e01-778b-400a-a7f6-3289c681d405"
                }



                );
        }
    }
}
