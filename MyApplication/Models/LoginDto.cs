using System.ComponentModel.DataAnnotations;

namespace MyApplication.Models
{
    public class LoginDto
    {
        [EmailAddress]
        public string Email { get; set; }
        [MinLength(6)]
        public string Password { get; set; }
    }
}
