namespace sun_forecast_calculation_app.Calculators.Contracts
{
    internal interface IAirmassCalculator
    {
        double calculateAirmass(double sunZenith, double localPressure, double seaLevelPresure);
    }
}