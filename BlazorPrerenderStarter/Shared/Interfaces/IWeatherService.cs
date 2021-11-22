using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPrerenderStarter.Shared.Interfaces;

public interface IWeatherService
{
    Task<List<WeatherForecast>> GetWeatherForecasts();
}
