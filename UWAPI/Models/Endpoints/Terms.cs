using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWAPI.Models.Response.Terms;

namespace UWAPI.Models.Endpoints
{
    public static class Terms
    {
        public static UwUrlCommand<ListingResponse> Listing()
        {
            return new UwUrlCommand<ListingResponse>("/terms/list");
        }

        public static UwUrlCommand<ExamScheduleTermResponse> ExamScheduleTerm(string term)
        {
            return new UwUrlCommand<ExamScheduleTermResponse>("/terms/{term}/examschedule", new Dictionary<string, string>()
            {
                {"term", term}
            });
        }

        public static UwUrlCommand<SubjectScheduleByTermResponse> SubjectScheduleByTerm(string term, string subject)
        {
            return new UwUrlCommand<SubjectScheduleByTermResponse>("/terms/{term}/{subject}/schedule", new Dictionary<string, string>()
            {
                {"term", term},
                {"subject", subject}
            });
        }

        public static UwUrlCommand<CourseScheduleByTermResponse> CourseScheduleByTerm(string term, string subject, string catalogNumber)
        {
            return new UwUrlCommand<CourseScheduleByTermResponse>("/terms/{term}/{subject}/{catalog_number}/schedule", new Dictionary<string, string>()
            {
                {"term", term},
                {"subject", subject},
                {"catalog_number", catalogNumber}
            });
        }

        public static UwUrlCommand<InfoSessionsByTermResponse> InfoSessionsByTerm(string term)
        {
            return new UwUrlCommand<InfoSessionsByTermResponse>("/terms/{term}/infosessions", new Dictionary<string, string>()
            {
                {"term", term}
            });
        }
    }
}
