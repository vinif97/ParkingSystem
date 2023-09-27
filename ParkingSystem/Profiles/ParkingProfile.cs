using AutoMapper;
using ParkingSystem.DTOs;
using ParkingSystem.Models;

namespace ParkingSystem.Profiles
{
    public class ParkingProfile : Profile
    {
        public ParkingProfile()
        {
            CreateMap<ParkingCreateRequest, Parking>();
        }
    }
}
