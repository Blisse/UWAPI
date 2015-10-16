using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.FoodServices
{
    public class LocationsResponse : UwUrlResponse
    {
        public class Hours
        {
            [JsonProperty("opening_hour")]
            public string OpeningHour { get; set; }

            [JsonProperty("closing_hour")]
            public string ClosingHour { get; set; }

            [JsonProperty("is_closed")]
            public bool IsClosed { get; set; }
        }

        public class OpeningHours
        {
            [JsonProperty("sunday")]
            public Hours Sunday { get; set; }

            [JsonProperty("monday")]
            public Hours Monday { get; set; }

            [JsonProperty("tuesday")]
            public Hours Tuesday { get; set; }

            [JsonProperty("wednesday")]
            public Hours Wednesday { get; set; }

            [JsonProperty("thursday")]
            public Hours Thursday { get; set; }

            [JsonProperty("friday")]
            public Hours Friday { get; set; }

            [JsonProperty("saturday")]
            public Hours Saturday { get; set; }
        }

        public class SpecialHour
        {
            [JsonProperty("date")]
            public string Date { get; set; }

            [JsonProperty("opening_hour")]
            public string OpeningHour { get; set; }

            [JsonProperty("closing_hour")]
            public string ClosingHour { get; set; }
        }

        public class Datum
        {
            [JsonProperty("outlet_id")]
            public int? OutletId { get; set; }

            [JsonProperty("outlet_name")]
            public string OutletName { get; set; }

            [JsonProperty("building")]
            public string Building { get; set; }

            [JsonProperty("logo")]
            public string Logo { get; set; }

            [JsonProperty("latitude")]
            public double Latitude { get; set; }

            [JsonProperty("longitude")]
            public double Longitude { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("notice")]
            public string Notice { get; set; }

            [JsonProperty("is_open_now")]
            public bool IsOpenNow { get; set; }

            [JsonProperty("opening_hours")]
            public OpeningHours OpeningHours { get; set; }

            [JsonProperty("special_hours")]
            public IList<SpecialHour> SpecialHours { get; set; }

            [JsonProperty("dates_closed")]
            public IList<object> DatesClosed { get; set; }
        }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }
}
