using Microsoft.AspNetCore.Identity;

namespace SapphireSports.Areas.Identity.Data
{
    public class SapphireSportsUser : IdentityUser
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
    }
}
