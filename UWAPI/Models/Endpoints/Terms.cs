using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWAPI.Models.Endpoints
{
    public static class Terms
    {
        public static UwUrlCommand Listing()
        {
            return new UwUrlCommand("/terms/list");
        }

        public static UwUrlCommand ExamScheduleTerm(string term)
        {
            return new UwUrlCommand("/terms/{term}/examschedule", new Dictionary<string, string>()
            {
                {"term", term}
            });
        }

        public static UwUrlCommand SubjectScheduleByTerm(string term, string subject)
        {
            return new UwUrlCommand("/terms/{term}/{subject}/schedule", new Dictionary<string, string>()
            {
                {"term", term},
                {"subject", subject}
            });
        }

        public static UwUrlCommand CourseScheduleByTerm(string term, string subject, string catalogNumber)
        {
            return new UwUrlCommand("/terms/{term}/{subject}/{catalog_number}/schedule", new Dictionary<string, string>()
            {
                {"term", term},
                {"subject", subject},
                {"catalog_number", catalogNumber}
            });
        }

        public static UwUrlCommand InfoSessionsByTerm(string term)
        {
            return new UwUrlCommand("/terms/{term}/infosessions", new Dictionary<string, string>()
            {
                {"term", term}
            });
        }
    }
}
