using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UWAPI.Models.Response.Weather;

namespace UWAPI.Models.Response
{
    public class UwUrlResponse
    {
        public class Method
        {
            [JsonProperty("site_name")]
            public string SiteName { get; set; }

            [JsonProperty("disclaimer")]
            public string Disclaimer { get; set; }

            [JsonProperty("license")]
            public string License { get; set; }
        }

        public class Metadata
        {
            [JsonProperty("requests")]
            public int Requests { get; set; }

            [JsonProperty("timestamp")]
            public int Timestamp { get; set; }

            [JsonProperty("status")]
            public int Status { get; set; }

            [JsonProperty("message")]
            public string Message { get; set; }

            [JsonProperty("method_id")]
            public int MethodId { get; set; }

            [JsonProperty("version")]
            public double Version { get; set; }

            [JsonProperty("method")]
            public Method Method { get; set; }
        }

        [JsonProperty("meta")]
        public Metadata Meta { get; set; }

    }
}
