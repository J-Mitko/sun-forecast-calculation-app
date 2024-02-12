using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sun_forecast_calculation_app.Calculators.Contracts;

namespace sun_forecast_calculation_app.Calculators
{
    internal class SolarTime : ISolarTime
    {
        private readonly ITimeCorrection timeCorrectionCalculator;
        public SolarTime(ITimeCorrection timeCorrectionCalculator)
        {
            this.timeCorrectionCalculator = timeCorrectionCalculator;
        }

        public double getSolarTime(long currentTime, double longitude, int dayOfYear)
        {
            int timezone = getTimezone(currentTime);
            int hour = getHour(currentTime);
            int localStandartTimeMeridian = getLocalStandartTimeMeridian(timezone);

            return hour + this.timeCorrectionCalculator.getTimeCorrenction(longitude, localStandartTimeMeridian, dayOfYear) / 60;
        }
        private int getTimezone(long currentTime)
        {
            return TimeZone.CurrentTimeZone.GetUtcOffset(DateTimeOffset.FromUnixTimeSeconds(currentTime).DateTime).Hours;
        }
        private int getHour(long currentTime)
        {
            return DateTimeOffset.FromUnixTimeSeconds(currentTime).DateTime.Hour;
        }
        private static int getLocalStandartTimeMeridian(int timezone)
        {
            return 15 * Math.Abs(timezone);
        }

    }
}
