namespace CargoOperatingSystem.Client
{
    using System.Linq;
    using System.Security.Claims;
    using System.Text.Json;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
    using Microsoft.AspNetCore.Components.WebAssembly.Authentication.Internal;

    // This is required because multiple roles arrive in json string array format ["",""]
    // The demonstration will work with any user besides "abi" without this as Abi has multiple roles. 
    public class RolesAccountClaimsPrincipalFactory : AccountClaimsPrincipalFactory<RemoteUserAccount>
    {
        public RolesAccountClaimsPrincipalFactory(IAccessTokenProviderAccessor accessor) : base(accessor) { }

        public override async ValueTask<ClaimsPrincipal> CreateUserAsync(
         RemoteUserAccount account,
         RemoteAuthenticationUserOptions options)
        {
            ClaimsPrincipal user = await base.CreateUserAsync(account, options);

            if (user.Identity.IsAuthenticated)
            {
                var identity = (ClaimsIdentity)user.Identity;
                Claim[] roleClaims = identity.FindAll(identity.RoleClaimType).ToArray();

                if (roleClaims != null && roleClaims.Any())
                {
                    foreach (Claim existingClaim in roleClaims)
                    {
                        identity.RemoveClaim(existingClaim);
                    }

                    var rolesElem = account.AdditionalProperties[identity.RoleClaimType];

                    if (rolesElem is JsonElement roles)
                    {
                        if (roles.ValueKind == JsonValueKind.Array)
                        {
                            foreach (JsonElement role in roles.EnumerateArray())
                            {
                                identity.AddClaim(new Claim(options.RoleClaim, role.GetString()));
                            }
                        }
                        else
                        {
                            identity.AddClaim(new Claim(options.RoleClaim, roles.GetString()));
                        }
                    }
                }
            }
            return user;
        }
    }
}
