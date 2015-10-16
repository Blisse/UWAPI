using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.Events
{
    public class EventsFromSiteResponse : UwUrlResponse
    {
        public class Time
        {
            [JsonProperty("start")]
            public DateTime Start { get; set; }

            [JsonProperty("end")]
            public DateTime End { get; set; }
        }

        public class Datum
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("times")]
            public IList<Time> Times { get; set; }

            [JsonProperty("type")]
            public IList<string> Type { get; set; }

            [JsonProperty("link")]
            public string Link { get; set; }

            [JsonProperty("updated")]
            public DateTime Updated { get; set; }
        }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }
}
