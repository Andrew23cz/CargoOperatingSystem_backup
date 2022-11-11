using Microsoft.AspNetCore.Authorization;

namespace CargoOperatingSystem.Shared
{


    public static class AuthorizationOptionsExtensions
    {

        

        public static AuthorizationOptions AddOnlyDsvPolicy(this AuthorizationOptions options)
        {
            options.AddPolicy("DsvOnlyPolicy", policy => policy.RequireClaim(CustomClaimTypes.Company, "Dsv"));
            return options;
        }

        public static AuthorizationOptions AddOnlyCargopointPolicy(this AuthorizationOptions options)
        {
            options.AddPolicy("CargopointOnlyPolicy", policy => policy.RequireClaim(CustomClaimTypes.Company, "Cargopoint"));
            return options;
        }

        public static AuthorizationOptions AddOnlyCompanyPolicy(this AuthorizationOptions options)
        {
            options.AddPolicy("CargopointOnlyPolicy", policy => policy.RequireClaim("Company", CustomClaimTypes.Company));
            return options;
        }


        




    }



}
