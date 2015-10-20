using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Store;
using UWAPI.Models.Response.Weather;

namespace UWAPI.Models.Endpoints
{
    public static class Weather
    {
        public static UwUrlCommand<CurrentWeatherResponse> CurrentWeather()
        {
            return new UwUrlCommand<CurrentWeatherResponse>("/weather/current");
        }
    }
}
