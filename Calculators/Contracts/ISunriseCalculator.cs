namespace sun_forecast_calculation_app.Calculators.Contracts
{
    public interface ISunriseCalculator
    {
        double calculateSunrise(double latitude, double longitude, int localStandartTimeMeridian, int dayOfYear, double sunDeclination);
    }
}