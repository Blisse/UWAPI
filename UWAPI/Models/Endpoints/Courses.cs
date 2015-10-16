using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWAPI.Models.Response.Courses;

namespace UWAPI.Models.Endpoints
{
    public static class Courses
    {
        public static UwUrlCommand<SubjectListingsResponse> SubjectListings(string subject)
        {
            return new UwUrlCommand<SubjectListingsResponse>("/courses/{subject}", new Dictionary<string, string>()
            {
                {"subject", subject}
            });
        }

        public static UwUrlCommand<CourseInformationByCourseIdResponse> CourseInformationByCourseId(string courseId)
        {
            return new UwUrlCommand<CourseInformationByCourseIdResponse>("/courses/{course_id}", new Dictionary<string, string>()
            {
                {"course_id", courseId}
            });
        }

        public static UwUrlCommand<CourseScheduleByClassNumberResponse> CourseScheduleByClassNumber(string classNumber)
        {
            return new UwUrlCommand<CourseScheduleByClassNumberResponse>("/courses/{class_number}/schedule", new Dictionary<string, string>()
            {
                {"class_number", classNumber}
            });
        }

        public static UwUrlCommand<CourseInformationBySubjectAndCatalogNumberResponse> CourseInformationBySubjectAndCatalogNumber(string subject, string catalogNumber)
        {
            return new UwUrlCommand<CourseInformationBySubjectAndCatalogNumberResponse>("/courses/{subject}/{catalog_number}", new Dictionary<string, string>()
            {
                {"subject", subject},
                {"catalog_number", catalogNumber}
            });
        }

        public static UwUrlCommand<CourseScheduleBySubjectAndCatalogNumberResponse> CourseScheduleBySubjectAndCatalogNumber(string subject, string catalogNumber)
        {
            return new UwUrlCommand<CourseScheduleBySubjectAndCatalogNumberResponse>("/courses/{subject}/{catalog_number}/schedule", new Dictionary<string, string>()
            {
                {"subject", subject},
                {"catalog_number", catalogNumber}
            });
        }

        public static UwUrlCommand<CoursePrerequisitesBySubjectAndCatalogNumberResponse> CoursePrerequisitesBySubjectAndCatalogNumber(string subject, string catalogNumber)
        {
            return new UwUrlCommand<CoursePrerequisitesBySubjectAndCatalogNumberResponse>("/courses/{subject}/{catalog_number}/prerequisites", new Dictionary<string, string>()
            {
                {"subject", subject},
                {"catalog_number", catalogNumber}
            });
        }

        public static UwUrlCommand<CourseExamScheduleBySubjectAndCatalogNumberResponse> CourseExamScheduleBySubjectAndCatalogNumber(string subject, string catalogNumber)
        {
            return new UwUrlCommand<CourseExamScheduleBySubjectAndCatalogNumberResponse>("/courses/{subject}/{catalog_number}/examschedule", new Dictionary<string, string>()
            {
                {"subject", subject},
                {"catalog_number", catalogNumber}
            });
        }

    }
}
