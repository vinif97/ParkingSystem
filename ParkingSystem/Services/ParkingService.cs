using AutoMapper;
using ParkingSystem.DTOs;
using ParkingSystem.Infrastructure.Repositories.Interfaces;
using ParkingSystem.Models;
using ParkingSystem.Services.Interfaces;

namespace ParkingSystem.Services
{
    public class ParkingService : IParkingService
    {
        private readonly IParkingRepository _parkingRepository;
        private readonly IParkingSectionRepository _parkingSectionRepository;
        private readonly IMapper _mapper;

        public ParkingService(IParkingRepository parkingRepository, IParkingSectionRepository parkingSectionRepository, IMapper mapper) 
        {
            _parkingSectionRepository = parkingSectionRepository;
            _parkingRepository = parkingRepository;
            _mapper = mapper;
        }

        public void CreateParking(ParkingCreateRequest parkingRequest)
        {
            Parking parking = _mapper.Map<Parking>(parkingRequest);
            _parkingRepository.Add(parking);
        }

        public IEnumerable<Parking> GetAllParking() 
        { 
            return _parkingRepository.GetAllParking().ToList();
        }

        public void CreateParkingSection(ParkingSectionCreateRequest parkingSectionRequest)
        {
            Parking parking = _parkingRepository.GetById(parkingSectionRequest.ParkingId);
            ParkingSection parkingSection = _mapper.Map<ParkingSection>(parkingSectionRequest);
            parkingSection.SynchronizePark(parking);

            _parkingSectionRepository.Add(parkingSection);
        }
    }
}
