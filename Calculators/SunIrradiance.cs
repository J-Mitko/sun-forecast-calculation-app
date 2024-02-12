using sun_forecast_calculation_app.Calculators.Contracts;
using sun_forecast_calculation_app.WeatherModel;
using System.Text.Json;

namespace sun_forecast_calculation_app.Calculators
{
    internal class SunIrradiance : ISunIrradiance
    {
        IAirmass airmass;
        ICloudTransmittens cloudTransmittens;
        IHourAngle hourAngle;
        ISunDeclination sunDeclination;
        ISolarTime solarTime;
        ISunZenit sunZenit;
        IIrradiance irradiance;

        public SunIrradiance(IAirmass airmass,
            ICloudTransmittens cloudTransmittens,
            IHourAngle hourAngle,
            ISunDeclination sunDeclination,
            ISolarTime solarTime,
            ISunZenit sunZenit,
            IIrradiance irrad)
        {
            this.airmass = airmass;
            this.cloudTransmittens = cloudTransmittens;
            this.hourAngle = hourAngle;
            this.sunDeclination = sunDeclination;
            this.solarTime = solarTime;
            this.sunZenit = sunZenit;
            this.irradiance = irrad;
        }

        public void calculateSunIrradiance(WeatherResponse weather, double longitude, double latitude)
        {
            weather.list.ForEach(delegate (WeatherForecast wf)
            {
                double transmittens = cloudTransmittens.getAtmosphereTransmittens(wf.clouds.all);
                int dayOfYear = DateTimeOffset.FromUnixTimeSeconds(wf.dt).DateTime.DayOfYear;

                double sunDeclination = this.sunDeclination.getSunDeclination(dayOfYear);
                double solarTime = this.solarTime.getSolarTime(wf.dt, longitude, dayOfYear);
                double hourAngle = this.hourAngle.getHourAngle(solarTime);
                double cosSunZenith = Math.Cos(DegRad.DegreesToRadians(sunZenit.getSunZenithAngle(latitude, sunDeclination, hourAngle)));
                if( cosSunZenith > 0)
                {
                    double airmass = this.airmass.getAirmassAbsolute(cosSunZenith, wf.main.pressure, wf.main.sea_level);
                    var result = irradiance.getSunIrradians(cosSunZenith, airmass, transmittens);

                    Console.WriteLine(wf.dt_txt + " -> dhi: " + result.dhi + " dni: " + result.dni + " ghi: " + result.ghi);
                }
            });
        }
    }
}
