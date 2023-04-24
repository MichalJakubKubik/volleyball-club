using System.ComponentModel.DataAnnotations;

namespace MyApplication.Models
{
    public class CreateClubDto
    {
        [MaxLength(32)]
        public string? ShortName { get; set; }
        [MaxLength(128)]
        public string FullName { get; set; }
        [MaxLength(128)]
        [EmailAddress]
        public string ContactEmail { get; set; }
        [MaxLength(16)]
        [Phone]
        public string ContactNumber { get; set; }
        [MaxLength(64)]
        public string City { get; set; }
        [MaxLength(64)]
        public string Street { get; set; }
        [MaxLength(16)]
        public string PostalCode { get; set; }
        [MaxLength(16)]
        public string LeagueName { get; set; }
    }
}
