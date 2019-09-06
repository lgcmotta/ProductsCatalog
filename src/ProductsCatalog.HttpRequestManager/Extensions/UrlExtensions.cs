using System.Linq;
using System.Text;
using ProductsCatalog.HttpRequestManager.Enumerations;
using ProductsCatalog.HttpRequestManager.Parameters;

namespace ProductsCatalog.HttpRequestManager.Extensions
{
    public static class UrlExtensions
    {
        private static readonly StringBuilder StringBuilder = new StringBuilder();

        public static string AppendProtocol(this string url, RequestProtocol requestProtocol)
        {
            return StringBuilder
                .Clear()
                .Append(requestProtocol
                    .ToString()
                    .ToLower())
                .Append("://")
                .Append(url)
                .ToString();
        }

        public static string AppendPath(this string url, string path, bool lastPath = false)
        {
            StringBuilder.Clear();

            if (!url.EndsWith("/"))
                StringBuilder.Append(url).Append("/");

            url = StringBuilder
                .Append(StringBuilder.ToString().Contains(url) ? string.Empty : url)
                .Append(path.StartsWith("/")
                    ? path.Remove(0, 1)
                    : path)
                .Append(lastPath ? string.Empty : "/")
                .ToString();

            return url;
        }

        public static string AddQueryString(this string url, UrlParameter[] parameters)
        {
            StringBuilder.Clear().Append("?");

            var urlParameters = parameters.ToList();

            urlParameters.ToList().ForEach(p =>
            {
                StringBuilder.Append(p)
                    .Append(urlParameters.IndexOf(p) < urlParameters.Count - 1
                        ? "&"
                        : string.Empty);
            });

            return StringBuilder.ToString();
        }
    }
}