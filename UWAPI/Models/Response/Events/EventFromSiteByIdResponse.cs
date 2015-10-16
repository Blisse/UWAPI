using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.Events
{
    public class EventFromSiteByIdResponse : UwUrlResponse
    {
        public class Time
        {
            [JsonProperty("start")]
            public DateTime Start { get; set; }

            [JsonProperty("end")]
            public DateTime End { get; set; }

            [JsonProperty("start_day")]
            public string StartDay { get; set; }

            [JsonProperty("start_date")]
            public string StartDate { get; set; }

            [JsonProperty("start_time")]
            public string StartTime { get; set; }

            [JsonProperty("end_day")]
            public string EndDay { get; set; }

            [JsonProperty("end_date")]
            public string EndDate { get; set; }

            [JsonProperty("end_time")]
            public string EndTime { get; set; }
        }

        public class Website
        {
            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }
        }

        public class Host
        {
            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }
        }

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

        public class Location
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("street")]
            public string Street { get; set; }

            [JsonProperty("additional")]
            public object Additional { get; set; }

            [JsonProperty("city")]
            public string City { get; set; }

            [JsonProperty("province")]
            public string Province { get; set; }

            [JsonProperty("postal_code")]
            public string PostalCode { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("latitude")]
            public object Latitude { get; set; }

            [JsonProperty("longitude")]
            public object Longitude { get; set; }
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

            [JsonProperty("times")]
            public IList<Time> Times { get; set; }

            [JsonProperty("cost")]
            public object Cost { get; set; }

            [JsonProperty("audience")]
            public IList<string> Audience { get; set; }

            [JsonProperty("tags")]
            public IList<object> Tags { get; set; }

            [JsonProperty("type")]
            public IList<string> Type { get; set; }

            [JsonProperty("website")]
            public Website Website { get; set; }

            [JsonProperty("host")]
            public Host Host { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("location")]
            public Location Location { get; set; }

            [JsonProperty("site_name")]
            public string SiteName { get; set; }

            [JsonProperty("site_id")]
            public string SiteId { get; set; }

            [JsonProperty("revision_id")]
            public int RevisionId { get; set; }

            [JsonProperty("link")]
            public string Link { get; set; }

            [JsonProperty("link_calendar")]
            public string LinkCalendar { get; set; }

            [JsonProperty("updated")]
            public DateTime Updated { get; set; }
        }

        [JsonProperty("data")]
        public Datum Data { get; set; }
    }
}
