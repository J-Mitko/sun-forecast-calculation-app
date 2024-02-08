using sun_forecast_calculation_app.WeatherModels;

namespace sun_forecast_calculation_app.Calculators.Contracts
{
    internal interface IIrradianceCalculator
    {
        SunIrradiationData calculateIrradians(double sunZenith, double airmass, double transmittens);
    }
}