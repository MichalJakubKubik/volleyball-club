namespace MyApplication.Entities
{
    public class CoachOccupation
    {
        public int Id { get; set; }
        public string OccupationName { get; set; }
        public virtual List<Coach> Coaches { get; set; } = new List<Coach>();
    }
}
