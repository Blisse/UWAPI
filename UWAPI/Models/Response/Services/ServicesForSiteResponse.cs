using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.Services
{
    public class ServicesForSiteResponse : UwUrlResponse
    {
        public class RequestInfo
        {
            [JsonProperty("procedure")]
            public string Procedure { get; set; }

            [JsonProperty("completion_time")]
            public string CompletionTime { get; set; }

            [JsonProperty("minimum_notice")]
            public string MinimumNotice { get; set; }
        }

        public class Hours
        {
            [JsonProperty("opening_hour")]
            public string OpeningHour { get; set; }

            [JsonProperty("closing_hour")]
            public string ClosingHour { get; set; }

            [JsonProperty("is_closed")]
            public bool IsClosed { get; set; }
        }

        public class OpeningHours
        {
            [JsonProperty("sunday")]
            public Hours Sunday { get; set; }

            [JsonProperty("monday")]
            public Hours Monday { get; set; }

            [JsonProperty("tuesday")]
            public Hours Tuesday { get; set; }

            [JsonProperty("wednesday")]
            public Hours Wednesday { get; set; }

            [JsonProperty("thursday")]
            public Hours Thursday { get; set; }

            [JsonProperty("friday")]
            public Hours Friday { get; set; }

            [JsonProperty("saturday")]
            public Hours Saturday { get; set; }
        }

        public class Location
        {
            [JsonProperty("id")]
            public int? Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("street")]
            public string Street { get; set; }

            [JsonProperty("additional")]
            public string Additional { get; set; }

            [JsonProperty("city")]
            public object City { get; set; }

            [JsonProperty("province")]
            public object Province { get; set; }

            [JsonProperty("postal_code")]
            public object PostalCode { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("latitude")]
            public double? Latitude { get; set; }

            [JsonProperty("longitude")]
            public double? Longitude { get; set; }
        }

        public class Additional
        {
        }

        public class Datum
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("cost")]
            public string Cost { get; set; }

            [JsonProperty("is_open_now")]
            public bool IsOpenNow { get; set; }

            [JsonProperty("contact_information")]
            public string ContactInformation { get; set; }

            [JsonProperty("notice")]
            public string Notice { get; set; }

            [JsonProperty("services_available")]
            public IList<string> ServicesAvailable { get; set; }

            [JsonProperty("request_info")]
            public RequestInfo RequestInfo { get; set; }

            [JsonProperty("opening_hours")]
            public OpeningHours OpeningHours { get; set; }

            [JsonProperty("special_hours")]
            public IList<object> SpecialHours { get; set; }

            [JsonProperty("dates_closed")]
            public IList<object> DatesClosed { get; set; }

            [JsonProperty("location")]
            public Location Location { get; set; }

            [JsonProperty("category")]
            public IList<string> Category { get; set; }

            [JsonProperty("audience")]
            public IList<string> Audience { get; set; }

            [JsonProperty("site_name")]
            public string SiteName { get; set; }

            [JsonProperty("site_id")]
            public string SiteId { get; set; }

            [JsonProperty("revision_id")]
            public int RevisionId { get; set; }

            [JsonProperty("additional")]
            public Additional Additional { get; set; }

            [JsonProperty("link")]
            public string Link { get; set; }

            [JsonProperty("updated")]
            public DateTime Updated { get; set; }
        }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }
}
