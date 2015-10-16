using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.FoodServices
{
    public class OutletsResponse : UwUrlResponse
    {
        public class Datum
        {
            [JsonProperty("outlet_id")]
            public int OutletId { get; set; }

            [JsonProperty("outlet_name")]
            public string OutletName { get; set; }

            [JsonProperty("has_breakfast")]
            public int HasBreakfast { get; set; }

            [JsonProperty("has_lunch")]
            public int HasLunch { get; set; }

            [JsonProperty("has_dinner")]
            public int HasDinner { get; set; }
        }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }
}
