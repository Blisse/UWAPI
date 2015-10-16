using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.News
{
    public class NewsFromSiteResponse : UwUrlResponse
    {
        public class Datum
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("link")]
            public string Link { get; set; }

            [JsonProperty("published")]
            public DateTime Published { get; set; }

            [JsonProperty("updated")]
            public DateTime Updated { get; set; }
        }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }
}
