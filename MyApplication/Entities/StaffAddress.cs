namespace MyApplication.Entities
{
    public class StaffAddress
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public virtual List<Staff> Staffs { get; set; } = new List<Staff>();
    }
}
