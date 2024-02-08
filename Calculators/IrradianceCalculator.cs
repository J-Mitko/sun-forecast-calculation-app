using sun_forecast_calculation_app.Calculators.Contracts;
using sun_forecast_calculation_app.WeatherModels;

namespace sun_forecast_calculation_app.Calculator
{
    class IrradianceCalculator : IIrradianceCalculator
    {
        private const double dni_extra = 1367.0;
        private SunIrradiationData sunIrradiance = new SunIrradiationData();

        public SunIrradiationData calculateIrradians(double sunZenith, double airmass, double transmittens)
        {
            sunIrradiance.dni = dni_extra * transmittens * airmass;
            sunIrradiance.dhi = 0.3 * (1.0 - transmittens * airmass) * dni_extra * sunZenith;
            sunIrradiance.ghi = sunIrradiance.dhi + sunIrradiance.dni * sunZenith;

            return sunIrradiance;
        }
    }
}
