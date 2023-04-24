namespace MyApplication.Entities
{
    public class PlayerPosition
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
        public virtual List<Player> Players { get; set; } = new List<Player>();
    }
}
