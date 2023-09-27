using AutoMapper;
using ParkingSystem.DTOs;
using ParkingSystem.Models;

namespace ParkingSystem.Profiles
{
    public class ParkingSectionProfile : Profile
    {
        public ParkingSectionProfile()
        {
            CreateMap<ParkingSectionCreateRequest, ParkingSection>();
        }
    }
}
