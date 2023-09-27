using ParkingSystem.Infrastructure.Repositories.Interfaces;
using ParkingSystem.Models;

namespace ParkingSystem.Infrastructure.Repositories
{
    public class ParkingSectionRepository : IParkingSectionRepository
    {
        private readonly ParkingContext _context;

        public ParkingSectionRepository(ParkingContext context)
        {
            _context = context;
        }

        public void Add(ParkingSection parkingSection)
        {
            _context.ParkingSections.Add(parkingSection);
            _context.SaveChanges();
        }
    }
}
