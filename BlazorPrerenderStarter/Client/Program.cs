using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorPrerenderStarter.Client.Services;
using BlazorPrerenderStarter.Shared.Interfaces;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddHttpClient<IWeatherService, WeatherService>(client =>
                client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
await builder.Build().RunAsync();
