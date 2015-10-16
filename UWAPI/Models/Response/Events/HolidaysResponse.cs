using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.Events
{
    public class HolidaysResponse : UwUrlResponse
    {
        public class Datum
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("date")]
            public string Date { get; set; }
        }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }
}
