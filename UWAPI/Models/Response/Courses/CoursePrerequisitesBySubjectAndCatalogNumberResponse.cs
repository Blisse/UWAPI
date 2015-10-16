using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.Courses
{
    public class CoursePrerequisitesBySubjectAndCatalogNumberResponse : UwUrlResponse
    {
        public class Datum
        {
            [JsonProperty("subject")]
            public string Subject { get; set; }

            [JsonProperty("catalog_number")]
            public string CatalogNumber { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("prerequisites")]
            public string Prerequisites { get; set; }

            [JsonProperty("prerequisites_parsed")]
            public IList<IList<object>> PrerequisitesParsed { get; set; }
        }

        [JsonProperty("data")]
        public Datum Data { get; set; }
    }
}
