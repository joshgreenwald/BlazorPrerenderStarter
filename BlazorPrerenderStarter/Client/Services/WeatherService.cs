namespace BlazorPrerenderStarter.Client.Services;

using System.Collections.Generic;
using System.Net.Http.Json;
using BlazorPrerenderStarter.Shared;
using BlazorPrerenderStarter.Shared.Interfaces;

public class WeatherService : IWeatherService
{
    HttpClient _httpClient;
    public WeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<WeatherForecast>> GetWeatherForecasts()
    {
        var forecast = await _httpClient.GetFromJsonAsync<List<WeatherForecast>>("WeatherForecast");
        return forecast;
    }
}
