using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.Courses
{
    public class CourseScheduleBySubjectAndCatalogNumberResponse : UwUrlResponse
    {
        public class Dates
        {
            [JsonProperty("start_time")]
            public string StartTime { get; set; }

            [JsonProperty("end_time")]
            public string EndTime { get; set; }

            [JsonProperty("weekdays")]
            public string Weekdays { get; set; }

            [JsonProperty("start_date")]
            public object StartDate { get; set; }

            [JsonProperty("end_date")]
            public object EndDate { get; set; }

            [JsonProperty("is_tba")]
            public bool IsTba { get; set; }

            [JsonProperty("is_cancelled")]
            public bool IsCancelled { get; set; }

            [JsonProperty("is_closed")]
            public bool IsClosed { get; set; }
        }

        public class Location
        {

            [JsonProperty("building")]
            public string Building { get; set; }

            [JsonProperty("room")]
            public string Room { get; set; }
        }

        public class Class
        {

            [JsonProperty("dates")]
            public Dates Dates { get; set; }

            [JsonProperty("location")]
            public Location Location { get; set; }

            [JsonProperty("instructors")]
            public IList<string> Instructors { get; set; }
        }

        public class Datum
        {

            [JsonProperty("subject")]
            public string Subject { get; set; }

            [JsonProperty("catalog_number")]
            public string CatalogNumber { get; set; }

            [JsonProperty("units")]
            public double Units { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("note")]
            public object Note { get; set; }

            [JsonProperty("class_number")]
            public int ClassNumber { get; set; }

            [JsonProperty("section")]
            public string Section { get; set; }

            [JsonProperty("campus")]
            public string Campus { get; set; }

            [JsonProperty("associated_class")]
            public int AssociatedClass { get; set; }

            [JsonProperty("related_component_1")]
            public object RelatedComponent1 { get; set; }

            [JsonProperty("related_component_2")]
            public object RelatedComponent2 { get; set; }

            [JsonProperty("enrollment_capacity")]
            public int EnrollmentCapacity { get; set; }

            [JsonProperty("enrollment_total")]
            public int EnrollmentTotal { get; set; }

            [JsonProperty("waiting_capacity")]
            public int WaitingCapacity { get; set; }

            [JsonProperty("waiting_total")]
            public int WaitingTotal { get; set; }

            [JsonProperty("topic")]
            public object Topic { get; set; }

            [JsonProperty("reserves")]
            public IList<object> Reserves { get; set; }

            [JsonProperty("classes")]
            public IList<Class> Classes { get; set; }

            [JsonProperty("held_with")]
            public IList<string> HeldWith { get; set; }

            [JsonProperty("term")]
            public int Term { get; set; }

            [JsonProperty("academic_level")]
            public string AcademicLevel { get; set; }

            [JsonProperty("last_updated")]
            public DateTime LastUpdated { get; set; }
        }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }
}
