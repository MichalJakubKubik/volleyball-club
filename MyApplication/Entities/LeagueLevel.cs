namespace MyApplication.Entities
{
    public class LeagueLevel
    {
        public int LeagueLevelNumber { get; set; }
        public string LeagueName { get; set; }
        public virtual List<Club> Clubs { get; set; } = new List<Club>();
    }
}
