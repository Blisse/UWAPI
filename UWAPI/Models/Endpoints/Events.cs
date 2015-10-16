using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWAPI.Models.Endpoints
{
    public static class Events
    {
        public static UwUrlCommand EventsFromAllSites()
        {
            return new UwUrlCommand("/events");
        }

        public static UwUrlCommand EventsFromSite(string site)
        {
            return new UwUrlCommand("/events/{site}",
                new Dictionary<string, string>()
                {
                    {"site", site}
                });
        }

        public static UwUrlCommand EventFromSiteById(string site, string id)
        {
            return new UwUrlCommand("/events/{site}/{id}",
                new Dictionary<string, string>()
                {
                    {"site", site},
                    {"id", id}
                });
        }

        public static UwUrlCommand Holidays()
        {
            return new UwUrlCommand("/events/holidays");
        }
    }
}
