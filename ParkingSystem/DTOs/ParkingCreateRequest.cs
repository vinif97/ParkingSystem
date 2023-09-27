namespace ParkingSystem.DTOs
{
    public record ParkingCreateRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public ParkingCreateRequest(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}
