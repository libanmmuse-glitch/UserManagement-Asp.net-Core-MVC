using Microsoft.AspNetCore.Identity;

namespace UserManagement.Models
{
    public class Users:IdentityUser
    {
        public string Fullname { get; set; }
    }
}
