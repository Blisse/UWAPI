using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.Terms
{
    public class ExamScheduleTermResponse : UwUrlResponse
    {
        public class Section
        {
            [JsonProperty("section")]
            public string SectionNumber { get; set; }

            [JsonProperty("day")]
            public string Day { get; set; }

            [JsonProperty("date")]
            public string Date { get; set; }

            [JsonProperty("start_time")]
            public string StartTime { get; set; }

            [JsonProperty("end_time")]
            public string EndTime { get; set; }

            [JsonProperty("location")]
            public string Location { get; set; }

            [JsonProperty("notes")]
            public string Notes { get; set; }
        }

        public class Datum
        {
            [JsonProperty("course")]
            public string Course { get; set; }

            [JsonProperty("sections")]
            public IList<Section> Sections { get; set; }
        }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }
}
