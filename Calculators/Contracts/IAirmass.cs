namespace sun_forecast_calculation_app.Calculators.Contracts
{
    internal interface IAirmass
    {
        double getAirmassAbsolute(double sunZenith, double localPressure, double seaLevelPresure);
    }
}