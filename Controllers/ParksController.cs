using Microsoft.AspNetCore.Mvc;
using ParkPlaceApi.Services;

namespace ParkPlaceApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParksController : ControllerBase
    {
        private readonly ILogger<ParksController> _logger;
        private readonly IParksService parksService;

        public ParksController(ILogger<ParksController> logger, IParksService _parksService)
        {
            _logger = logger;
            this.parksService = _parksService;
        }

        [HttpGet(Name = "GetParks")]
        public IEnumerable<Park> Get()
        {
            return parksService.GetParks();
        }
    }
}