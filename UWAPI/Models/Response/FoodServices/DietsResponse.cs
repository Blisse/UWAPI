using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.FoodServices
{
    public class DietsResponse : UwUrlResponse
    {
        public class Datum
        {
            [JsonProperty("diet_id")]
            public int DietId { get; set; }

            [JsonProperty("diet_type")]
            public string DietType { get; set; }
        }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }
}
