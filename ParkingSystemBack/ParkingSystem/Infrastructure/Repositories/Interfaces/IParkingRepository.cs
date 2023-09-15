using ParkingSystem.Models;

namespace ParkingSystem.Infrastructure.Repositories.Interfaces
{
    public interface IParkingRepository
    {
        void Add(Parking parking);
        IQueryable<Parking> GetAllParking();
        Parking GetById(int id);
    }
}
