using Microsoft.EntityFrameworkCore;
using ParkingSystem.Models;

namespace ParkingSystem.Infrastructure
{
    public class ParkingContext : DbContext
    {
        public ParkingContext(DbContextOptions<ParkingContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Parking> Parkings { get; set; }
        public DbSet<ParkingSection> ParkingSections { get; set; }
    }
}
