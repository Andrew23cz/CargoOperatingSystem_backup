namespace CargoOperatingSystem.Server
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.Options;
    using CargoOperatingSystem.Server.Models;
    using CargoOperatingSystem.Shared;

    public class AdditionalUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser, IdentityRole>
    {
        public AdditionalUserClaimsPrincipalFactory(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IOptions<IdentityOptions> optionsAccessor)
            : base(userManager, roleManager, optionsAccessor)
        { }

        public override async Task<ClaimsPrincipal> CreateAsync(ApplicationUser user)
        {
            ClaimsPrincipal principal = await base.CreateAsync(user);
            var identity = (ClaimsIdentity)principal.Identity;
            var claims = new List<Claim>
            {
                new Claim(CustomClaimTypes.Company, user.Company)
            };
            identity.AddClaims(claims);
            return principal;

            
        }
    }
}

