namespace sun_forecast_calculation_app.Calculators.Contracts
{
    internal interface ICloudTransmittensCalculator
    {
        double calculateTransmittens(int cloudCover);
    }
}