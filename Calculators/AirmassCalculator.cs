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
        public double calculateAirmassAbsolute(double cosSunZenith, double localPressure, double seaLevelPresure)
        {
            return calculateAirmassRelative(cosSunZenith) * localPressure / seaLevelPresure;
        }

        private double calculateAirmassRelative(double cosSunZenith) 
        {
            return 1 / cosSunZenith;
        }
    }
}
