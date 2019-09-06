using System;
using ProductsCatalog.HttpRequestManager.Enumerations;
using ProductsCatalog.HttpRequestManager.Extensions;

namespace ProductsCatalog.HttpRequestManager.Builders
{
    public class RequestUriBuilder
    {
        private string _body;

        public RequestUriBuilder(string body)
        {
            _body = body;
        }

        public RequestUriBuilder BuildBaseUrl(RequestProtocol protocol)
        {
            if (string.IsNullOrEmpty(_body) || string.IsNullOrWhiteSpace(_body))
                throw new ArgumentNullException(nameof(_body));

            _body = _body.AppendProtocol(protocol);

            return this;
        }

        public RequestUriBuilder AppendPath(string path, bool lastPath = false)
        {
            _body = _body.AppendPath(path, lastPath);

            return this;
        }

        public string Build()
        {
            return _body;
        }

        public void Dispose()
        {
            _body = null;
            GC.Collect();
        }
    }
}