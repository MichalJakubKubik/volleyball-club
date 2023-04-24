using System.ComponentModel.DataAnnotations;

namespace MyApplication.Models
{
    public class RegisterUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int UserRoleId { get; set; } = 1;
        public int? ManagingClubId { get; set; }
    }
}
