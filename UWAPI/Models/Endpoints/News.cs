using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWAPI.Models.Endpoints
{
    public static class News
    {
        public static UwUrlCommand NewsFromAllSites()
        {
            return new UwUrlCommand("/news");
        }

        public static UwUrlCommand NewsFromSite(string site)
        {
            return new UwUrlCommand("/news/{site}",
                new Dictionary<string, string>()
                {
                    {"site", site}
                });
        }

        public static UwUrlCommand NewsFromSiteById(string site, string id)
        {
            return new UwUrlCommand("/news/{site}/{id}",
                new Dictionary<string, string>()
                {
                    {"site", site},
                    {"id", id}
                });
        }
    }
}
