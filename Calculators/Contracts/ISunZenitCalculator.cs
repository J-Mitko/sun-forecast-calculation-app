namespace sun_forecast_calculation_app.Calculators.Contracts
{
    internal interface ISunZenitCalculator
    {
        double calculateSunZenith(double latitude, double sunDeclination, double hourAngle);
    }
}