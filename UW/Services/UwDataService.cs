using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWAPI.Models.Endpoints;
using UWAPI.Models.Response.Codes;
using UWAPI.Models.Response.Courses;
using UWAPI.Models.Response.Events;
using UWAPI.Models.Response.FoodServices;
using UWAPI.Models.Response.News;
using UWAPI.Models.Response.Services;
using UWAPI.Models.Response.Terms;
using UWAPI.Models.Response.Weather;
using UWAPI.Services;

namespace UW.Services
{
    public class UwDataService : IUwDataService
    {
        private UwService _uwService;

        public UwDataService()
        {
            "bf4ebcb2717418c1e1be8454f6935ad9";
        }

        public void Initialize(string apiKey)
        {
            if (_uwService != null)
            {
                _uwService = new UwService(apiKey);
            }
        }

        public UwService GetService()
        {
            return _uwService;
        }
    }

    public interface IUwDataService
    {
        void Initialize(string apiKey);

        UwService GetService();
    }
}
