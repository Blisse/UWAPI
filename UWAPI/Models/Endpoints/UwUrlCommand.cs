using System;
using System.Collections.Generic;
using System.IO;

namespace UWAPI.Models.Endpoints
{
    public class UwUrlCommand
    {
        private readonly string _basePath = "https://api.uwaterloo.ca/v2/";

        private readonly string _path;

        private readonly IDictionary<string, string> _namedParams;

        internal UwUrlCommand(string path, IDictionary<string, string> namedParams = null)
        {
            _path = path ?? string.Empty;
            _namedParams = namedParams ?? new Dictionary<string, string>();
        }
        
        public override string ToString()
        {
            string url = Path.Combine(_basePath, _path);

            IDictionary<string, string> namedParams = _namedParams;
            if (namedParams != null)
            {
                url = url.FormatFromDictionary(namedParams);
            }

            return url;
        }
    }
}
