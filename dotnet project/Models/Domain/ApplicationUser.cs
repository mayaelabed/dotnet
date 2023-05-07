using Microsoft.AspNetCore.Identity;

namespace dotnet_project.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
