namespace sun_forecast_calculation_app.Calculators.Contracts
{
    public interface ITimeCorrectionCalculator
    {
        double calculateEoT(int dayOfYear);
        double calculateTimeCorrenction(double longitude, int localStandartTimeMeridian, int dayOfYear);
    }
}