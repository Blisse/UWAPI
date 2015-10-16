using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWAPI.Models.Endpoints
{
    public static class Codes
    {
        public static UwUrlCommand OrganizationalUnits()
        {
            return new UwUrlCommand("/codes/units");
        }

        public static UwUrlCommand Terms()
        {
            return new UwUrlCommand("/codes/terms");
        }

        public static UwUrlCommand Groups()
        {
            return new UwUrlCommand("/codes/groups");
        }
        public static UwUrlCommand Instructions()
        {
            return new UwUrlCommand("/codes/instructions");
        }
    }
}
