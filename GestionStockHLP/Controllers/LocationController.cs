using GestionStockHLP.Repository.Models;
using GestionStockHLP.Services.LocationService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionStockHLP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;
        public LocationController(ILocationService locationService) 
        {
            _locationService = locationService;
        }
        [HttpPost]
        [Route("InsertLocation")]
        public void Postlocation(Locationfinder location)
        {
            _locationService.setLocation(location);
        }

    }
}
