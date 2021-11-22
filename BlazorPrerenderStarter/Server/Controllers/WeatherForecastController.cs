using Microsoft.AspNetCore.Mvc;
using BlazorPrerenderStarter.Shared;
using BlazorPrerenderStarter.Shared.Interfaces;

namespace BlazorPrerenderStarter.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(IWeatherService weatherService, ILogger<WeatherForecastController> logger)
        {
            _weatherService = weatherService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            return await _weatherService.GetWeatherForecasts();
        }
    }
}