namespace sun_forecast_calculation_app.Calculators.Contracts
{
    internal interface ISolarTimeCalculator
    {
        double calculateSolarTime(long currentTime, double longitude, int dayOfYear);
    }
}