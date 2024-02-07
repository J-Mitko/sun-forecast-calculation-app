using sun_forecast_calculation_app.Calculators.Contracts;

namespace sun_forecast_calculation_app.Calculators
{
    internal class CloudTransmittensCalculator : ICloudTransmittensCalculator
    {

        private const double OFFSET = 0.75;
        public double calculateTransmittens(int cloudCover)
        {
            return ((100.0 - cloudCover) / 100.0) * OFFSET;
        }
    }
}
