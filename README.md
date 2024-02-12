# sun-forecast-calculation-app

App that gets weather forecast data from the openweathermap and calculates how much sunshine will be.

The program requires input user openweathermap api key, latitude and longitude for the location where the calculations to be performed.

The program calls "https://api.openweathermap.org/data/2.5/forecast", where it receives the weather forecast for the next 5 days in 3 hour intervals. The programs exclude results if the sun below the horizon. 

The program outputs dhi (Diffuse Horizontal Irradiance), dni (Direct Normal Irradiance), ghi (Global Horizontal Irradiance) in W/m^2. They are calculated using Liu and Jordan formula from there simplified direct radiation model.
 
 
References

    .. [1] Campbell, G. S., J. M. Norman (1998) An Introduction to
       Environmental Biophysics. 2nd Ed. New York: Springer.

    .. [2] Liu, B. Y., R. C. Jordan, (1960). "The interrelationship and
       characteristic distribution of direct, diffuse, and total solar
       radiation".  Solar Energy 4:1-19
