namespace sun_forecast_calculation_app
{
    public class DegRad
    {
        public static double DegreesToRadians(double degrees)
        {
            return Math.Round((degrees * Math.PI / 180.0), 2);
        }
        public static double RadiansToDegrees(double radians)
        {
            return Math.Round((radians * 180 / Math.PI), 2);
        }
    }
}
