using BlazorPrerenderStarter.Shared;
using BlazorPrerenderStarter.Shared.Interfaces;

namespace BlazorPrerenderStarter.Server.Services
{
    public class WeatherService : IWeatherService
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<List<WeatherForecast>> GetWeatherForecasts()
        {
            List<WeatherForecast> forecast = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToList();

            return Task.FromResult(forecast);
        }
    }
}
