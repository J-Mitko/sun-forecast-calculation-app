namespace sun_forecast_calculation_app.Calculators.Contracts
{
    internal interface IIrradCalculator
    {
        void calculateIrradians(double sunZenith, double airmass, double transmittens);
    }
}