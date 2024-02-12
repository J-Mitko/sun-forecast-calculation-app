# sun-forecast-calculation-app

App that gets weather forecast data from the openweathermap and calculates how much sunshine will be.

The program requires input user openweathermap api key, latitude and longitude for the location where the calculations to be performed.

The program calls "https://api.openweathermap.org/data/2.5/forecast", where it receives the weather forecast for the next 5 days in 3 hour intervals.

The program outputs dhi (Diffuse Horizontal Irradiance), dni (Direct Normal Irradiance), ghi (Global Horizontal Irradiance).
