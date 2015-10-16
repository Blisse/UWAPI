using System;
using System.Collections.Generic;
using System.IO;
using UWAPI.Models.Response;

namespace UWAPI.Models.Endpoints
{
    public class UwUrlCommand<TResponse> where TResponse : UwUrlResponse
    {
        private readonly string _basePath = "https://api.uwaterloo.ca/v2";
        private readonly string _path;
        private readonly IDictionary<string, string> _namedParams;
        private readonly Type _responseType;

        internal UwUrlCommand(string path, IDictionary<string, string> namedParams = null)
        {
            _path = path;
            _namedParams = namedParams ?? new Dictionary<string, string>();
            _responseType = typeof(TResponse);
        }

        public Type ResponseType()
        {
            return _responseType;
        }

        public override string ToString()
        {
            string url = _basePath + _path;

            IDictionary<string, string> namedParams = _namedParams;
            if (namedParams != null)
            {
                url = url.FormatFromDictionary(namedParams);
            }

            return url;
        }
    }
}
