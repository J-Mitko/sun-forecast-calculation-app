# sun-forecast-calculation-app

App that gets weather forecast data from the openweathermap and calculates how much sunshine will be.

The program requires input user openweathermap api key, latitude and longitude for the location where the calculations to be performed.

The program calls "https://api.openweathermap.org/data/2.5/forecast", where it receives the weather forecast for the next 5 days in 3 hour intervals.

The program outputs dhi (Diffuse Horizontal Irradiance), dni (Direct Normal Irradiance), ghi (Global Horizontal Irradiance) in W/m^2. They are calculated using Liu and Jordan(1960) formula.
Liu, B. Y., R. C. Jordan, (1960). "The interrelationship and
       characteristic distribution of direct, diffuse, and total solar
       radiation".  Solar Energy 4:1-19
