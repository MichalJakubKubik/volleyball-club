using System.Diagnostics.CodeAnalysis;

namespace MyApplication.Entities
{
    public class Club
    {
        public int Id { get; set; }
        public string? ShortName { get; set; }
        public string FullName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }
        public virtual ClubAddress ClubAddress { get; set; }
        public virtual List<Player> Players { get; set; } = new List<Player>();
        public virtual List<Coach> Coaches { get; set; } = new List<Coach>();
        public int LeagueLevelId { get; set; }
        public virtual LeagueLevel LeagueLevel { get; set; }
        public virtual User ManagingUser { get; set; }
    }
}
