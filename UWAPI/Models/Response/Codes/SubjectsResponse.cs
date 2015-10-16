using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.Codes
{
    public class SubjectsResponse : UwUrlResponse
    {
        public class Datum
        {
            [JsonProperty("subject")]
            public string Subject { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("unit")]
            public string Unit { get; set; }

            [JsonProperty("group")]
            public string Group { get; set; }
        }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }
}
