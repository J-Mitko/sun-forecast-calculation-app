using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sun_forecast_calculation_app.Calculators.Contracts;

namespace sun_forecast_calculation_app.Calculators
{
    internal class Airmass : IAirmass
    {
        public double getAirmassAbsolute(double cosSunZenith, double localPressure, double seaLevelPresure)
        {
            return getAirmassRelative(cosSunZenith) * localPressure / seaLevelPresure;
        }

        private double getAirmassRelative(double cosSunZenith) 
        {
            return 1 / cosSunZenith;
        }
    }
}
