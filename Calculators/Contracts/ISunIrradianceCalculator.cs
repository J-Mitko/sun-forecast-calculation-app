﻿using sun_forecast_calculation_app.WeatherModel;

namespace sun_forecast_calculation_app.Calculators.Contracts
{
    internal interface ISunIrradianceCalculator
    {
        void calculateSunIrradiance(WeatherResponse weather, double longitude, double latitude);
    }
}