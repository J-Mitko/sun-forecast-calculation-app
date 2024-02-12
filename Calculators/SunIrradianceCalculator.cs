using sun_forecast_calculation_app.Calculators.Contracts;
using sun_forecast_calculation_app.WeatherModel;
using System.Text.Json;

namespace sun_forecast_calculation_app.Calculators
{
    internal class SunIrradianceCalculator : ISunIrradianceCalculator
    {
        IAirmassCalculator airmassCalculator;
        ICloudTransmittensCalculator cloudTransmittensCalculator;
        IHourAngleCalculator hourAngleCalculator;
        ISunDeclinationCalculator sunDeclinationCalculator;
        ISolarTimeCalculator solarTimeCalculator;
        ISunZenitCalculator sunZenitCalculator;
        IIrradianceCalculator irradCalculator;

        public SunIrradianceCalculator(IAirmassCalculator airmassCalculator,
            ICloudTransmittensCalculator cloudTransmittensCalculator,
            IHourAngleCalculator hourAngleCalculator,
            ISunDeclinationCalculator sunDeclinationCalculator,
            ISolarTimeCalculator solarTimeCalculator,
            ISunZenitCalculator sunZenitCalculator,
            IIrradianceCalculator irradCalculator)
        {
            this.airmassCalculator = airmassCalculator;
            this.cloudTransmittensCalculator = cloudTransmittensCalculator;
            this.hourAngleCalculator = hourAngleCalculator;
            this.sunDeclinationCalculator = sunDeclinationCalculator;
            this.solarTimeCalculator = solarTimeCalculator;
            this.sunZenitCalculator = sunZenitCalculator;
            this.irradCalculator = irradCalculator;
        }

        public void calculateSunIrradiance(WeatherResponse weather, double longitude, double latitude)
        {
            weather.list.ForEach(delegate (WeatherForecast wf)
            {
                double transmittens = cloudTransmittensCalculator.calculateTransmittens(wf.clouds.all);
                int dayOfYear = DateTimeOffset.FromUnixTimeSeconds(wf.dt).DateTime.DayOfYear;

                double sunDeclination = sunDeclinationCalculator.calculateSunDeclination(dayOfYear);
                double solarTime = solarTimeCalculator.calculateSolarTime(wf.dt, longitude, dayOfYear);
                double hourAngle = hourAngleCalculator.calculateHourAngle(solarTime);
                double cosSunZenith = Math.Cos(DegRad.DegreesToRadians(sunZenitCalculator.calculateSunZenith(latitude, sunDeclination, hourAngle)));
                double airmass = airmassCalculator.calculateAirmass(cosSunZenith, wf.main.pressure, wf.main.sea_level);

                var result = irradCalculator.calculateIrradians(cosSunZenith, airmass, transmittens);

                Console.WriteLine(wf.dt_txt + " -> dhi: " + result.dhi + " dni: " + result.dni + " ghi: " + result.ghi);
            });
        }
    }
}
