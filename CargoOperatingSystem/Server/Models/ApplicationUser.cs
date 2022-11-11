using Microsoft.AspNetCore.Identity;

namespace CargoOperatingSystem.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string Company { get; set; }

    }
}
