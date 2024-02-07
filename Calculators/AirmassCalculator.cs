using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sun_forecast_calculation_app.Calculators.Contracts;

namespace sun_forecast_calculation_app.Calculators
{
    internal class AirmassCalculator : IAirmassCalculator
    {
        public double calculateAirmass(double sunZenith, double localPressure, double seaLevelPresure)
        {
            return 1 / sunZenith * localPressure / seaLevelPresure;
        }
    }
}
