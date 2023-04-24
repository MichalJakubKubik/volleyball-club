using MyApplication.Entities;

namespace MyApplication.Models
{
    public class ClubDto
    {
        public string? ShortName { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string LeagueName { get; set; }
        public List<PlayerDto> Players { get; set; }
        public List<CoachDto> Coaches { get; set; }
    }
}
