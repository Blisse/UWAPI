using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.Weather
{
    public class CurrentWeatherResponse : UwUrlResponse
    {
        public class Datum
        {
            [JsonProperty("latitude")]
            public double Latitude { get; set; }

            [JsonProperty("longitude")]
            public double Longitude { get; set; }

            [JsonProperty("elevation_m")]
            public double ElevationM { get; set; }

            [JsonProperty("observation_time")]
            public DateTime ObservationTime { get; set; }

            [JsonProperty("temperature_current_c")]
            public double TemperatureCurrentC { get; set; }

            [JsonProperty("humidex_c")]
            public object HumidexC { get; set; }

            [JsonProperty("windchill_c")]
            public double WindchillC { get; set; }

            [JsonProperty("temperature_24hr_max_c")]
            public double Temperature24hrMaxC { get; set; }

            [JsonProperty("temperature_24hr_min_c")]
            public double Temperature24hrMinC { get; set; }

            [JsonProperty("precipitation_15min_mm")]
            public object Precipitation15minMm { get; set; }

            [JsonProperty("precipitation_1hr_mm")]
            public double Precipitation1hrMm { get; set; }

            [JsonProperty("precipitation_24hr_mm")]
            public double Precipitation24hrMm { get; set; }

            [JsonProperty("relative_humidity_percent")]
            public double RelativeHumidityPercent { get; set; }

            [JsonProperty("dew_point_c")]
            public double DewPointC { get; set; }

            [JsonProperty("wind_speed_kph")]
            public double WindSpeedKph { get; set; }

            [JsonProperty("wind_direction_degrees")]
            public double WindDirectionDegrees { get; set; }

            [JsonProperty("pressure_kpa")]
            public double PressureKpa { get; set; }

            [JsonProperty("pressure_trend")]
            public string PressureTrend { get; set; }

            [JsonProperty("incoming_shortwave_radiation_wm2")]
            public double IncomingShortwaveRadiationWm2 { get; set; }
        }

        [JsonProperty("data")]
        public Datum Data { get; set; }
    }
}
