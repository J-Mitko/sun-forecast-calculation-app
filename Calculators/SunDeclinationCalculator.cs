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
            double a = Math.Round(360d / 365 * (dayOfYear + 10), 2);

            return -23.45 * Math.Round(Math.Cos(DegRad.DegreesToRadians(a)), 2);
        }
    }
}
