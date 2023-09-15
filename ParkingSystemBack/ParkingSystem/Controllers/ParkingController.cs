using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingSystem.DTOs;
using ParkingSystem.Models;
using ParkingSystem.Services.Interfaces;

namespace ParkingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        private readonly IParkingService _parkingService;

        public ParkingController(IParkingService parkingService)
        { 
            _parkingService = parkingService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Parking>> GetParkings()
        {
            var parkings = _parkingService.GetAllParking();
            return Ok(parkings);    
        }

        [HttpPost]
        public IActionResult CreateParking(ParkingCreateRequest parkingRequest)
        {
            _parkingService.CreateParking(parkingRequest);
            return Ok();
        }

        [HttpPost]
        [Route("Section")]
        public IActionResult CreateParkingSection(ParkingSectionCreateRequest parkingSectionRequest)
        {
            _parkingService.CreateParkingSection(parkingSectionRequest);
            return Ok();
        }
    }
}
