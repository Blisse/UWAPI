using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.News
{
    public class NewsFromSiteByIdResponse : UwUrlResponse
    {
        public class Image
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("file")]
            public string File { get; set; }

            [JsonProperty("alt")]
            public string Alt { get; set; }

            [JsonProperty("mime")]
            public string Mime { get; set; }

            [JsonProperty("size")]
            public int Size { get; set; }

            [JsonProperty("width")]
            public int Width { get; set; }

            [JsonProperty("height")]
            public int Height { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }
        }

        public class Datum
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("description_raw")]
            public string DescriptionRaw { get; set; }

            [JsonProperty("audience")]
            public IList<object> Audience { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("site_id")]
            public string SiteId { get; set; }

            [JsonProperty("site_name")]
            public string SiteName { get; set; }

            [JsonProperty("revision_id")]
            public int RevisionId { get; set; }

            [JsonProperty("published")]
            public DateTime Published { get; set; }

            [JsonProperty("updated")]
            public DateTime Updated { get; set; }

            [JsonProperty("link")]
            public string Link { get; set; }
        }

        [JsonProperty("data")]
        public Datum Data { get; set; }
    }
}
