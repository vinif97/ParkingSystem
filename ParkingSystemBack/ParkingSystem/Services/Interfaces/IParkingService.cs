using ParkingSystem.DTOs;
using ParkingSystem.Models;

namespace ParkingSystem.Services.Interfaces
{
    public interface IParkingService
    {
        void CreateParking(ParkingCreateRequest parkingRequest);
        IEnumerable<Parking> GetAllParking();
        void CreateParkingSection(ParkingSectionCreateRequest parkingSectionRequest);
    }
}
