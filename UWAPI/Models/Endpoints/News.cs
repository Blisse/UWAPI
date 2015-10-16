using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWAPI.Models.Response.News;

namespace UWAPI.Models.Endpoints
{
    public static class News
    {
        public static UwUrlCommand<NewsFromAllSitesResponse> NewsFromAllSites()
        {
            return new UwUrlCommand<NewsFromAllSitesResponse>("/news");
        }

        public static UwUrlCommand<NewsFromSiteResponse> NewsFromSite(string site)
        {
            return new UwUrlCommand<NewsFromSiteResponse>("/news/{site}",
                new Dictionary<string, string>()
                {
                    {"site", site}
                });
        }

        public static UwUrlCommand<NewsFromSiteByIdResponse> NewsFromSiteById(string site, string id)
        {
            return new UwUrlCommand<NewsFromSiteByIdResponse>("/news/{site}/{id}",
                new Dictionary<string, string>()
                {
                    {"site", site},
                    {"id", id}
                });
        }
    }
}
