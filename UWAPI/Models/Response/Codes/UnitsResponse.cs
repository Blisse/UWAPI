using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.Codes
{
    public class UnitsResponse : UwUrlResponse
    {
        public class Datum
        {
            [JsonProperty("unit_code")]
            public string UnitCode { get; set; }

            [JsonProperty("group_code")]
            public string GroupCode { get; set; }

            [JsonProperty("unit_short_name")]
            public string UnitShortName { get; set; }

            [JsonProperty("unit_full_name")]
            public string UnitFullName { get; set; }
        }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }
}
