// See https://aka.ms/new-console-template for more information
public class WeatherForecast
{
    public int dt { get; set; }
    public string dt_txt { get; set; }
    public Main main { get; set; }
    public Clouds clouds { get; set; }

    public class Main 
    {
        public int sea_level { get; set; }
        public int pressure { get; set; }
    }
    public class Clouds
    {
        public int all { get; set; }
    }
}