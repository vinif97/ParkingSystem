using Microsoft.EntityFrameworkCore;
using ParkingSystem.DTOs;
using ParkingSystem.Infrastructure.Repositories.Interfaces;
using ParkingSystem.Models;

namespace ParkingSystem.Infrastructure.Repositories
{
    public class ParkingRepository : IParkingRepository
    {
        private readonly ParkingContext _context;

        public ParkingRepository(ParkingContext context) 
        {
            _context = context;
        }

        public void Add(Parking parking)
        {
            _context.Parkings.Add(parking);
            _context.SaveChanges();
        }

        public IQueryable<Parking> GetAllParking() 
        {
            return _context.Parkings.AsNoTrackingWithIdentityResolution().Include(p => p.ParkingSections);
        }

        public Parking GetById(int id) 
        {
            return _context.Parkings.Where(p => p.ParkingId == id).First();
        }
    }
}
