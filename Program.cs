using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using sun_forecast_calculation_app.Calculator;
using sun_forecast_calculation_app.Calculators;
using sun_forecast_calculation_app.Calculators.Contracts;
using sun_forecast_calculation_app.WeatherModel;
using System.Text.Json;

IHost builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddSingleton<IAirmassCalculator, AirmassCalculator>();
    services.AddSingleton<ICloudTransmittensCalculator, CloudTransmittensCalculator>();
    services.AddSingleton<IHourAngleCalculator, HourAngleCalculator>();
    services.AddSingleton<IIrradianceCalculator, IrradianceCalculator>();
    services.AddSingleton<ISolarTimeCalculator, SolarTimeCalculator>();
    services.AddSingleton<ISunDeclinationCalculator, SunDeclinationCalculator>();
    services.AddSingleton<ISunriseCalculator, SunriseCalculator>();
    services.AddSingleton<ISunZenitCalculator, SunZenitCalculator>();
    services.AddSingleton<ITimeCorrectionCalculator, TimeCorrectionCalculator>();
    services.AddSingleton<ISunIrradianceCalculator, SunIrradianceCalculator>();
}).Build();

var app = builder.Services.GetRequiredService<ISunIrradianceCalculator>();
string apiKey = String.Empty;
double latitude = 0f;
double longitude = 0f;

Console.Write("Enter your OpenWeatherMap API key: ");
string? apiKeyInput = Console.ReadLine();
if (apiKeyInput != null && apiKeyInput != String.Empty)
    apiKey = apiKeyInput.Trim();

Console.Write("Enter latitude: ");
string? latidudeInput = Console.ReadLine();
if(latidudeInput != null && latidudeInput != String.Empty)
    latitude = Convert.ToDouble(latidudeInput.Trim());

Console.Write("Enter longitude: ");
string? longitudeInput = Console.ReadLine();
if(longitudeInput != null && longitudeInput != String.Empty)
    longitude = Convert.ToDouble(longitudeInput.Trim());

Console.WriteLine();

using (HttpClient httpClient = new HttpClient())
{
    try
    {
        string apiUrl = $"https://api.openweathermap.org/data/2.5/forecast?lat={latitude}&lon={longitude}&appid={apiKey}";

        HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            WeatherResponse? weatherForecast = JsonSerializer.Deserialize<WeatherResponse>(json);

            if (weatherForecast != null)
            {
                app.calculateSunIrradiance(weatherForecast,longitude,latitude);
            }
        }
        else 
        {
            Console.WriteLine("Request has failed: " + response.ToString());
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
