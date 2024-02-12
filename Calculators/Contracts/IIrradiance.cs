using sun_forecast_calculation_app.WeatherModels;

namespace sun_forecast_calculation_app.Calculators.Contracts
{
    internal interface IIrradiance
    {
        SunIrradiationData getSunIrradians(double sunZenith, double airmass, double transmittens);
    }
}