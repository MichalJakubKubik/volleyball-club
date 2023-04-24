using Microsoft.AspNetCore.Identity;

namespace MyApplication.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int UserRoleId { get; set; }
        public virtual UserRole UserRole { get; set; }
        public int? ManagingClubId { get; set; }
        public virtual Club ManagingClub { get; set; }
    }
}
