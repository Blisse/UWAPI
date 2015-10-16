using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace UWAPI.Models.Response.Terms
{
    public class ListingResponse : UwUrlResponse
    {
        public class Term
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public class Listings
        {
            public IList<Term> Terms { get; set; }
        }

        public class Datum
        {

            [JsonProperty("previous_term")]
            public int PreviousTerm { get; set; }

            [JsonProperty("current_term")]
            public int CurrentTerm { get; set; }

            [JsonProperty("next_term")]
            public int NextTerm { get; set; }

            [JsonProperty("listings")]
            public Listings Listings { get; set; }
        }


        [JsonProperty("data")]
        public Datum Data { get; set; }
    }
}
