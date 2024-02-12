namespace sun_forecast_calculation_app.Calculators.Contracts
{
    public interface ITimeCorrection
    {
        double getEoT(int dayOfYear);
        double getTimeCorrenction(double longitude, int localStandartTimeMeridian, int dayOfYear);
    }
}