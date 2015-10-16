using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWAPI.Models.Response.Events;

namespace UWAPI.Models.Endpoints
{
    public static class Events
    {
        public static UwUrlCommand<EventsFromAllSitesResponse> EventsFromAllSites()
        {
            return new UwUrlCommand<EventsFromAllSitesResponse>("/events");
        }

        public static UwUrlCommand<EventsFromSiteResponse> EventsFromSite(string site)
        {
            return new UwUrlCommand<EventsFromSiteResponse>("/events/{site}",
                new Dictionary<string, string>()
                {
                    {"site", site}
                });
        }

        public static UwUrlCommand<EventFromSiteByIdResponse> EventFromSiteById(string site, string id)
        {
            return new UwUrlCommand<EventFromSiteByIdResponse>("/events/{site}/{id}",
                new Dictionary<string, string>()
                {
                    {"site", site},
                    {"id", id}
                });
        }

        public static UwUrlCommand<HolidaysResponse> Holidays()
        {
            return new UwUrlCommand<HolidaysResponse>("/events/holidays");
        }
    }
}
