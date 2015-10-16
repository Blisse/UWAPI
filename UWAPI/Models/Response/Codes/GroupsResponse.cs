using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.Codes
{
    public class GroupsResponse : UwUrlResponse
    {
        public class Datum
        {
            [JsonProperty("group_code")]
            public string GroupCode { get; set; }

            [JsonProperty("group_short_name")]
            public string GroupShortName { get; set; }

            [JsonProperty("group_full_name")]
            public string GroupFullName { get; set; }
        }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }
}
