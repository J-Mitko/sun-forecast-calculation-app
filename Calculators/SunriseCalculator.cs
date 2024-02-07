using sun_forecast_calculation_app.Calculators.Contracts;

namespace sun_forecast_calculation_app.Calculators
{
    public class SunriseCalculator : ISunriseCalculator
    {
        private readonly ITimeCorrectionCalculator timeCorrectionCalculator;

        public SunriseCalculator(ITimeCorrectionCalculator timeCorrectionCalculator)
        {
            this.timeCorrectionCalculator = timeCorrectionCalculator;
        }
        public double calculateSunrise(double latitude, double longitude, int localStandartTimeMeridian, int dayOfYear, double sunDeclination)
        {
            return 12 - 1 / 15 * Math.Acos(-Math.Tan(DegRad.DegreesToRadians(latitude) * Math.Tan(DegRad.DegreesToRadians(sunDeclination))))
                - timeCorrectionCalculator.calculateTimeCorrenction(longitude, localStandartTimeMeridian, dayOfYear);
        }

    }
}
