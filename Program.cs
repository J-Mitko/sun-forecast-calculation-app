using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using sun_forecast_calculation_app.Calculator;
using sun_forecast_calculation_app.Calculators;
using sun_forecast_calculation_app.Calculators.Contracts;

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
app.calculate();
