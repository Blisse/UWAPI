using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.Codes
{
    public class InstructionsResponse : UwUrlResponse
    {
        public class Datum
        {
            [JsonProperty("abbreviation")]
            public string Abbreviation { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }
        }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }
}
