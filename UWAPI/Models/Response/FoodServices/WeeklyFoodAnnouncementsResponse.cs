using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.FoodServices
{
    public class WeeklyFoodAnnouncementsResponse : UwUrlResponse
    {
        public class Datum
        {
            [JsonProperty("date")]
            public string Date { get; set; }

            [JsonProperty("ad_text")]
            public string AdText { get; set; }
        }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }
}
