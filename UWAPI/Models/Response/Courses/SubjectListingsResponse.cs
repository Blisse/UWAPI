using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.Courses
{
    public class SubjectListingsResponse : UwUrlResponse
    {
        public class Datum
        {
            [JsonProperty("course_id")]
            public string CourseId { get; set; }

            [JsonProperty("subject")]
            public string Subject { get; set; }

            [JsonProperty("catalog_number")]
            public string CatalogNumber { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("units")]
            public double Units { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("academic_level")]
            public string AcademicLevel { get; set; }
        }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }
}
