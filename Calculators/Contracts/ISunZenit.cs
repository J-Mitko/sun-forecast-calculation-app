namespace sun_forecast_calculation_app.Calculators.Contracts
{
    internal interface ISunZenit
    {
        double getSunZenithAngle(double latitude, double sunDeclination, double hourAngle);
    }
}