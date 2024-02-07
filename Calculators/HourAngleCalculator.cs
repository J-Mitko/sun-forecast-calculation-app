using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sun_forecast_calculation_app.Calculators.Contracts;

namespace sun_forecast_calculation_app.Calculators
{
    internal class HourAngleCalculator : IHourAngleCalculator
    {
        public double calculateHourAngle(double solarTime)
        {
            return 15 * (solarTime - 12);
        }
    }
}
