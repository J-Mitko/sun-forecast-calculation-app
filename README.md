# sun-forecast-calculation-app

App that gets weather forecast data from the openweatthermap and calculates how much sunshine will be.

The program requires to input user openweathermap api key, latitude and longitude for the location where the calculations to be performed.

It calls "https://api.openweathermap.org/data/2.5/forecast" endpoint where it receives weather forcast for the next 5 days in 3 hour intervals.

The program outpusts dhi (Diffuse Horizontal Irradiance), dni (Direct Normal Irradiance), ghi (Global Horizontal Irradiance).
