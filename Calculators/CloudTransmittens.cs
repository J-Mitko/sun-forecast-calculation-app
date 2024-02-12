using sun_forecast_calculation_app.Calculators.Contracts;

namespace sun_forecast_calculation_app.Calculators
{
    internal class CloudTransmittens : ICloudTransmittens
    {

        private const double OFFSET = 0.75;
        public double getAtmosphereTransmittens(int cloudCover)
        {
            return ((100.0 - cloudCover) / 100.0) * OFFSET;
        }
    }
}
