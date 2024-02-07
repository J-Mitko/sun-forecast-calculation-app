namespace sun_forecast_calculation_app.Calculators.Contracts
{
    internal interface ISunDeclinationCalculator
    {
        double calculateSunDeclination(int dayOfYear);
    }
}