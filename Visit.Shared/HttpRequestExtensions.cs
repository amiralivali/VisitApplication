using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Visit.Shared
{
    public static class HttpRequestExtensions
    {
        public static string GetCurlCommand(this HttpRequestMessage request)
        {
            var curlBuilder = new StringBuilder("curl");
            curlBuilder.Append($" -X {request.Method}");
            curlBuilder.Append($" \"{request.RequestUri}\"");

            foreach (var header in request.Headers)
                foreach (var value in header.Value)
                    curlBuilder.Append($" -H \"{header.Key}: {value}\"");

            if (request.Content != null)
            {
                foreach (var header in request.Content.Headers)
                    foreach (var value in header.Value)
                        curlBuilder.Append($" -H \"{header.Key}: {value}\"");

                var content = request.Content.ReadAsStringAsync().Result;

                if (!string.IsNullOrWhiteSpace(content))
                    curlBuilder.Append($" --data \"{content.Replace("\"", "\\\"")}\"");
            }

            return curlBuilder.ToString();
        }
    }
}
