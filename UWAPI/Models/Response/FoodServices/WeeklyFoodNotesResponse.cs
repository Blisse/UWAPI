using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.FoodServices
{
    public class WeeklyFoodNotesResponse : UwUrlResponse
    {
        public class Datum
        {
            [JsonProperty("date")]
            public string Date { get; set; }

            [JsonProperty("outlet_name")]
            public string OutletName { get; set; }

            [JsonProperty("outlet_id")]
            public int OutletId { get; set; }

            [JsonProperty("note")]
            public string Note { get; set; }
        }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }
}
