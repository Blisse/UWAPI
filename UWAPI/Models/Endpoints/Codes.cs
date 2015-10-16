using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWAPI.Models.Response.Codes;

namespace UWAPI.Models.Endpoints
{
    public static class Codes
    {
        public static UwUrlCommand<UnitsResponse> Units()
        {
            return new UwUrlCommand<UnitsResponse>("/codes/units");
        }

        public static UwUrlCommand<TermsResponse> Terms()
        {
            return new UwUrlCommand<TermsResponse>("/codes/terms");
        }

        public static UwUrlCommand<GroupsResponse> Groups()
        {
            return new UwUrlCommand<GroupsResponse>("/codes/groups");
        }

        public static UwUrlCommand<SubjectsResponse> Subjects()
        {
            return new UwUrlCommand<SubjectsResponse>("/codes/subjects");
        }

        public static UwUrlCommand<InstructionsResponse> Instructions()
        {
            return new UwUrlCommand<InstructionsResponse>("/codes/instructions");
        }
    }
}
