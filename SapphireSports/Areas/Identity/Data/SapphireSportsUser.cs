using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SapphireSports.Areas.Identity.Data
{
    public class SapphireSportsUser : IdentityUser
    {

        public string FirstName {  get; set; }
        public string LastName { get; set; }
    }
}
