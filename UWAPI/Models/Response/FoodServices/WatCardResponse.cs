using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.FoodServices
{
    public class WatCardResponse : UwUrlResponse
    {
        public class Datum
        {
            [JsonProperty("vendor_id")]
            public int VendorId { get; set; }

            [JsonProperty("vendor_name")]
            public string VendorName { get; set; }
        }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }
}
