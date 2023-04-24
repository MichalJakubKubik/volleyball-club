using System.ComponentModel.DataAnnotations;

namespace MyApplication.Models
{
    public class CreateCoachDto
    {
        [MaxLength(32)]
        public string FirstName { get; set; }
        [MaxLength(32)]
        public string? SecondName { get; set; }
        [MaxLength(32)]
        public string LastName { get; set; }
        [MaxLength(32)]
        public string CoachOccupationName { get; set; }
        [MaxLength(64)]
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
        [MaxLength(64)]
        public string PlaceOfBirth { get; set; }
        [MaxLength(128)]
        public string ContactEmail { get; set; }
        [MaxLength(16)]
        public string ContactNumber { get; set; }
        [MaxLength(64)]
        public string City { get; set; }
        [MaxLength(64)]
        public string Street { get; set; }
        [MaxLength(6)]
        public string PostalCode { get; set; }
        [MaxLength(128)]
        public string ClubName { get; set; }
    }
}
