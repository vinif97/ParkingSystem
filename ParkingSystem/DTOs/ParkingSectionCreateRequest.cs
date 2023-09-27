using ParkingSystem.Models;

namespace ParkingSystem.DTOs
{
    public record ParkingSectionCreateRequest
    {
        public int ParkingId { get; set; }
        public string ParkingSectionName { get; set; }
        public int TotalParkingLots { get; set; }

        public ParkingSectionCreateRequest(int parkingId, string parkingSectionName, int totalParkingLots)
        {
            ParkingId = parkingId;
            ParkingSectionName = parkingSectionName;
            TotalParkingLots = totalParkingLots;
        }
    }
}
