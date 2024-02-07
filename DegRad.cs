namespace sun_forecast_calculation_app
{
    public class DegRad
    {
        public static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }
        public double RadiansToDegrees(double radians)
        {
            return radians * 180 / Math.PI;
        }
    }
}
