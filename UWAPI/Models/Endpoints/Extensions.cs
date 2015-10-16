using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UWAPI.Models.Endpoints
{
    public static class Extensions
    {
        public static string FormatFromDictionary(this string formatString, IDictionary<string, string> valueDict)
        {
            int i = 0;
            StringBuilder newFormatString = new StringBuilder(formatString);
            IDictionary<string, int> keyToInt = new Dictionary<string, int>();
            foreach (var tuple in valueDict)
            {
                newFormatString = newFormatString.Replace("{" + tuple.Key + "}", "{" + i.ToString() + "}");
                keyToInt.Add(tuple.Key, i);
                i++;
            }

            // ReSharper disable once CoVariantArrayConversion
            return string.Format(newFormatString.ToString(), valueDict.OrderBy(x => keyToInt[x.Key]).Select(x => x.Value).ToArray());
        }

        public static string AppendQueryString(this string url, IDictionary<string, string> dict)
        {
            StringBuilder sb;
            if (url.Contains("?"))
            {
                sb = new StringBuilder(url + "&");
            }
            else
            {
                sb = new StringBuilder(url + "?");
            }

            bool first = true;
            foreach (string key in dict.Keys)
            {
                if (!first)
                {
                    sb.Append("&");
                }

                sb.AppendFormat("{0}={1}", Uri.EscapeDataString(key), Uri.EscapeDataString(dict[key]));

                first = false;
            }

            return url + sb;
        }
    }
}
