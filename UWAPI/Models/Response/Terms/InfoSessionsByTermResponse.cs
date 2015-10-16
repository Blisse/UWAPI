using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.Terms
{
    public class InfoSessionsByTermResponse : UwUrlResponse
    {
        public class Datum
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("employer")]
            public string Employer { get; set; }

            [JsonProperty("date")]
            public string Date { get; set; }

            [JsonProperty("start_time")]
            public string StartTime { get; set; }

            [JsonProperty("end_time")]
            public string EndTime { get; set; }

            [JsonProperty("location")]
            public string Location { get; set; }

            [JsonProperty("website")]
            public string Website { get; set; }

            [JsonProperty("audience")]
            public string Audience { get; set; }

            [JsonProperty("programs")]
            public string Programs { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }
        }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }
}
