using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sun_forecast_calculation_app.WeatherModels
{
    public class SunIrradiationData
    { 
        public double dni { get; set; }
        public double dhi { get; set; }
        public double ghi { get; set; }
    }
}
