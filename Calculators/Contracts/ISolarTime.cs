namespace sun_forecast_calculation_app.Calculators.Contracts
{
    internal interface ISolarTime
    {
        double getSolarTime(long currentTime, double longitude, int dayOfYear);
    }
}