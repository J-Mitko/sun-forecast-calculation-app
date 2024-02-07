using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sun_forecast_calculation_app.Calculators.Contracts;

namespace sun_forecast_calculation_app.Calculators
{
    internal class SunZenitCalculator : ISunZenitCalculator
    {
        public double calculateCosinSunZenith(double latitude, double sunDeclination, double hourAngle)
        {
            return Math.Asin(Math.Sin(DegRad.DegreesToRadians(latitude)) * Math.Sin(DegRad.DegreesToRadians(sunDeclination))
                + Math.Cos(DegRad.DegreesToRadians(latitude)) * Math.Cos(DegRad.DegreesToRadians(sunDeclination)) * Math.Cos(DegRad.DegreesToRadians(hourAngle)));
        }
    }
}
