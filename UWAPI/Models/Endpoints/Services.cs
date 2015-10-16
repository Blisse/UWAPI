using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWAPI.Models.Endpoints
{
    public static class Services
    {
        public static UwUrlCommand ServicesForSite(string site)
        {
            return new UwUrlCommand("/services/{site}", new Dictionary<string, string>()
            {
                {"site", site}
            });
        }
    }
}
