using sun_forecast_calculation_app.Calculators.Contracts;

namespace sun_forecast_calculation_app.Calculator
{
    internal class IrradCalculator : IIrradCalculator
    {
        private const double dni_extra = 1367.0;
        public double dni { get; set; }
        public double dhi { get; set; }
        public double ghi { get; set; }

        public void calculateIrradians(double sunZenith, double airmass, double transmittens)
        {
            dni = dni_extra * transmittens * airmass;
            dhi = 0.3 * (1.0 - transmittens * airmass) * dni_extra * sunZenith;
            ghi = dhi + dni * sunZenith;
        }
    }
}
