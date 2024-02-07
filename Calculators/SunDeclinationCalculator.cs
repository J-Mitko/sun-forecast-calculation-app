using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sun_forecast_calculation_app.Calculators.Contracts;

namespace sun_forecast_calculation_app.Calculators
{
    internal class SunDeclinationCalculator : ISunDeclinationCalculator
    {
        public double calculateSunDeclination(int dayOfYear)
        {
            double a = 360d / 365 * (dayOfYear + 10);

            return 23.44 * Math.Sin(DegRad.DegreesToRadians(a));
        }
    }
}
