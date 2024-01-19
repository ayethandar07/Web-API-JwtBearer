using Microsoft.AspNetCore.Identity;

namespace JwtAPI.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
    }
}
