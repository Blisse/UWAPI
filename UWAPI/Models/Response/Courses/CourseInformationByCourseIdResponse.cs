using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.Courses
{
    public class CourseInformationByCourseIdResponse : UwUrlResponse
    {
        public class Offerings
        {
            [JsonProperty("online")]
            public bool Online { get; set; }

            [JsonProperty("online_only")]
            public bool OnlineOnly { get; set; }

            [JsonProperty("st_jerome")]
            public bool StJerome { get; set; }

            [JsonProperty("st_jerome_only")]
            public bool StJeromeOnly { get; set; }

            [JsonProperty("renison")]
            public bool Renison { get; set; }

            [JsonProperty("renison_only")]
            public bool RenisonOnly { get; set; }

            [JsonProperty("conrad_grebel")]
            public bool ConradGrebel { get; set; }

            [JsonProperty("conrad_grebel_only")]
            public bool ConradGrebelOnly { get; set; }
        }

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

            [JsonProperty("instructions")]
            public IList<string> Instructions { get; set; }

            [JsonProperty("prerequisites")]
            public string Prerequisites { get; set; }

            [JsonProperty("antirequisites")]
            public string Antirequisites { get; set; }

            [JsonProperty("corequisites")]
            public string Corequisites { get; set; }

            [JsonProperty("crosslistings")]
            public object Crosslistings { get; set; }

            [JsonProperty("terms_offered")]
            public IList<string> TermsOffered { get; set; }

            [JsonProperty("notes")]
            public string Notes { get; set; }

            [JsonProperty("offerings")]
            public Offerings Offerings { get; set; }

            [JsonProperty("needs_department_consent")]
            public bool NeedsDepartmentConsent { get; set; }

            [JsonProperty("needs_instructor_consent")]
            public bool NeedsInstructorConsent { get; set; }

            [JsonProperty("extra")]
            public IList<object> Extra { get; set; }

            [JsonProperty("calendar_year")]
            public string CalendarYear { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("academic_level")]
            public string AcademicLevel { get; set; }
        }

        [JsonProperty("data")]
        public Datum Data { get; set; }
    }
}
