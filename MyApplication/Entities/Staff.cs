namespace MyApplication.Entities
{
    public abstract class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? SecondName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }
        public DateTime DateOfLeagueJoin { get; set; }
        public int StaffAddressId { get; set; }
        public virtual StaffAddress StaffAddress { get; set; }
        public int ClubId { get; set; }
        public virtual Club Club { get; set; }
    }

    public class Player : Staff
    {
        public int PlayerPositionId { get; set; }
        public virtual PlayerPosition PlayerPosition { get; set; }
        public int ShirtNumber { get; set; }
    }

    public class Coach : Staff
    {
        public int CoachOccupationId { get; set; }
        public virtual CoachOccupation CoachOccupation { get; set; }
    }
}
