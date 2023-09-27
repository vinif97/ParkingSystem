namespace ParkingSystem.Models
{
    public class Parking
    {
        public int ParkingId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<ParkingSection> ParkingSections { get; set; } = new List<ParkingSection>();

        public Parking(string name, string address)
        { 
            Name = name;
            Address = address;
        }
    }
}
