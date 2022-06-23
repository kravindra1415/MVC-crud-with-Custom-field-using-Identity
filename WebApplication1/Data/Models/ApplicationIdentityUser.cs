using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Data.Models
{
    public class ApplicationIdentityUser : IdentityUser
    {
        public int Age { get; set; }
    }
}
