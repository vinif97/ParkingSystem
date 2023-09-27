using ParkingSystem.DTOs;

namespace ParkingSystem.Models
{
    public class ParkingSection
    {
        public int ParkingSectionId { get; private set; }
        public string ParkingSectionName { get; private set; }
        public int TotalParkingLots { get; private set; }
        public int OccupiedParkingLots { get; private set; }
        public Parking Parking { get; private set; }
        public ICollection<Car> Cars { get; set; } = new List<Car>();

        public ParkingSection(Parking parking, string name, int totalParkingLots, int occupiedParkingLots = 0)
        {
            Parking = parking;
            ParkingSectionName = name;
            TotalParkingLots = totalParkingLots;
            OccupiedParkingLots = occupiedParkingLots;
        }

        public void SynchronizePark(Parking parking)
        {
            Parking = parking;
        }

#pragma warning disable CS8618 // EF Migration
        private ParkingSection() { }
#pragma warning restore CS8618 // EF Migration
    }
}
