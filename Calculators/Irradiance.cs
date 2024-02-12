using sun_forecast_calculation_app.Calculators.Contracts;
using sun_forecast_calculation_app.WeatherModels;

namespace sun_forecast_calculation_app.Calculator
{
    class Irradiance : IIrradiance
    {
        //Direct irradiance incident at the top of the atmosphere.
        private const double dni_extra = 1367.0;
        private SunIrradiationData sunIrradiance = new SunIrradiationData();

        public SunIrradiationData getSunIrradians(double sunZenith, double airmass, double transmittens)
        {
            sunIrradiance.dni = Math.Round(dni_extra * Math.Pow(transmittens, airmass),2);
            sunIrradiance.dhi = Math.Round(0.3 * (1.0 - Math.Pow(transmittens,airmass)) * dni_extra * sunZenith, 2);
            sunIrradiance.ghi = Math.Round(sunIrradiance.dhi + sunIrradiance.dni * sunZenith, 2);

            return sunIrradiance;
        }
    }
}
