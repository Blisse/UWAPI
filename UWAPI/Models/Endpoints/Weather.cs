using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Store;

namespace UWAPI.Models.Endpoints
{
    public static class Weather
    {
        public static UwUrlCommand Current()
        {
            return new UwUrlCommand("/weather/current");
        }
    }
}
