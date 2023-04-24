namespace MyApplication.Entities
{
    public class ClubAddress
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public int ClubId { get; set; }
        public virtual Club Club { get; set; }
    }
}
