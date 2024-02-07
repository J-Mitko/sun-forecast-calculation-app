using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sun_forecast_calculation_app.Calculators.Contracts;

namespace sun_forecast_calculation_app.Calculators
{
    public class TimeCorrectionCalculator : ITimeCorrectionCalculator
    {
        public double calculateTimeCorrenction(double longitude, int localStandartTimeMeridian, int dayOfYear)
        {
            return (4 * (longitude - localStandartTimeMeridian)) + calculateEoT(dayOfYear) / 60;
        }
        public double calculateEoT(int dayOfYear)
        {
            double b = 360 * (dayOfYear - 81) / 365;
            return 9.87 * Math.Sin(DegRad.DegreesToRadians(2 * b)) - 7.67 * Math.Sin(DegRad.DegreesToRadians(b + 78.7));
        }
    }
}
