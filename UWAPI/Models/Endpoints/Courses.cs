using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWAPI.Models.Endpoints
{
    public static class Courses
    {
        public static UwUrlCommand SubjectListings(string subject)
        {
            return new UwUrlCommand("/courses/{subject}", new Dictionary<string, string>()
            {
                {"subject", subject}
            });
        }

        public static UwUrlCommand CourseInformationByCourseId(string courseId)
        {
            return new UwUrlCommand("/courses/{course_id}", new Dictionary<string, string>()
            {
                {"course_id", courseId}
            });
        }

        public static UwUrlCommand CourseScheduleByClassNumber(string classNumber)
        {
            return new UwUrlCommand("/courses/{class_number}/schedule", new Dictionary<string, string>()
            {
                {"class_number", classNumber}
            });
        }

        public static UwUrlCommand CourseInformationBySubjectAndCatalogNumber(string subject, string catalogNumber)
        {
            return new UwUrlCommand("/courses/{subject}/{catalog_number}", new Dictionary<string, string>()
            {
                {"subject", subject},
                {"catalog_number", catalogNumber}
            });
        }

        public static UwUrlCommand CourseScheduleBySubjectAndCatalogNumber(string subject, string catalogNumber)
        {
            return new UwUrlCommand("/courses/{subject}/{catalog_number}/schedule", new Dictionary<string, string>()
            {
                {"subject", subject},
                {"catalog_number", catalogNumber}
            });
        }

        public static UwUrlCommand CoursePrerequisitesBySubjectAndCatalogNumber(string subject, string catalogNumber)
        {
            return new UwUrlCommand("/courses/{subject}/{catalog_number}/prerequisites", new Dictionary<string, string>()
            {
                {"subject", subject},
                {"catalog_number", catalogNumber}
            });
        }

        public static UwUrlCommand CourseExamScheduleBySubjectAndCatalogNumber(string subject, string catalogNumber)
        {
            return new UwUrlCommand("/courses/{subject}/{catalog_number}/examschedule", new Dictionary<string, string>()
            {
                {"subject", subject},
                {"catalog_number", catalogNumber}
            });
        }

    }
}
