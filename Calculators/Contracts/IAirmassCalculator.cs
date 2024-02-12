namespace sun_forecast_calculation_app.Calculators.Contracts
{
    internal interface IAirmassCalculator
    {
        double calculateAirmassAbsolute(double sunZenith, double localPressure, double seaLevelPresure);
    }
}