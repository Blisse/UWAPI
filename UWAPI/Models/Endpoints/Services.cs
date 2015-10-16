using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWAPI.Models.Response.Services;

namespace UWAPI.Models.Endpoints
{
    public static class Services
    {
        public static UwUrlCommand<ServicesForSiteResponse> ServicesForSite(string site)
        {
            return new UwUrlCommand<ServicesForSiteResponse>("/services/{site}", new Dictionary<string, string>()
            {
                {"site", site}
            });
        }
    }
}
