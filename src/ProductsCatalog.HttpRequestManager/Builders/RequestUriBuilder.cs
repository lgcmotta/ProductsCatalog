using System;
using ProductsCatalog.HttpRequestManager.Enumerations;
using ProductsCatalog.HttpRequestManager.Extensions;

namespace ProductsCatalog.HttpRequestManager.Builders
{
    public class RequestUriBuilder : IDisposable
    {
        public string Body { get; set; }

        public RequestUriBuilder(string body)
        {
            Body = body;
        }

        public RequestUriBuilder()
        {
            Body = string.Empty;
        }

        public RequestUriBuilder BuildBaseUrl(RequestProtocol protocol)
        {
            if (string.IsNullOrEmpty(Body) || string.IsNullOrWhiteSpace(Body))
                throw new ArgumentNullException(nameof(Body));

            Body = Body.AppendProtocol(protocol);

            return this;
        }

        public RequestUriBuilder AppendPath(string path, bool lastPath = false)
        {
            Body = Body.AppendPath(path, lastPath);

            return this;
        }

        public string Build()
        {
            return Body;
        }

        public void Dispose()
        {
            Body = null;
            GC.Collect();
        }
    }
}