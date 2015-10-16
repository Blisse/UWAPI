using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UWAPI.Models.Endpoints;
using UWAPI.Models.Response;

namespace UWAPI.Services
{
    public class UwService
    {
        private readonly Dictionary<string, string> _apiKeyQueryKey;
        private readonly HttpClient _httpClient;

        public UwService(string apiKey)
        {
            _apiKeyQueryKey = new Dictionary<string, string>()
            {
                {"key", apiKey}
            };
            _httpClient = new HttpClient();
        }

        public async Task<TResponse> ExecuteAsync<TResponse>(UwUrlCommand<TResponse> command) where TResponse : UwUrlResponse
        {
            TResponse uwResponse = null;

            var response = await _httpClient.GetAsync(CreateLegalUri(command));
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();

                uwResponse = JsonConvert.DeserializeObject<TResponse>(responseString, new JsonSerializerSettings()
                {
                    NullValueHandling = NullValueHandling.Ignore
                });
            }

            return uwResponse;
        }

        private Uri CreateLegalUri<TResponse>(UwUrlCommand<TResponse> command) where TResponse : UwUrlResponse
        {
            string url = command + ".json";

            url = url.AppendQueryString(_apiKeyQueryKey);

            return new Uri(url, UriKind.Absolute);
        }
    }
}
