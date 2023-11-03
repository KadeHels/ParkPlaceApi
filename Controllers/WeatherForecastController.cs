using Microsoft.AspNetCore.Mvc;
using ParkPlaceApi.Services;

namespace ParkPlaceApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForcastService _weatherForcastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForcastService weatherForcastService)
        {
            _logger = logger;
            _weatherForcastService = weatherForcastService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherForcastService.GetWeatherForcast();
        }
    }
}