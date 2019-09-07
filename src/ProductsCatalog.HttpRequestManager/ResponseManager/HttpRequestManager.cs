using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ProductsCatalog.ConversionExtensions.Json.Deserialize;
using ProductsCatalog.ConversionExtensions.Xml.Deserialize;
using ProductsCatalog.HttpRequestManager.Enumerations;

namespace ProductsCatalog.HttpRequestManager.ResponseManager
{
    public class RequestManager
    {
        public static async Task<T> GetRequestJsonObject<T>(string url, DecompressionMethods decompressionMethods, Encoding encoding) where T : class, new()
        {
            return await (await MakeRequest(url, RestMethods.Get, decompressionMethods, encoding)).DeserializeJsonStringAsync<T>();
        }

        public static async Task<T> GetResquestXmlObject<T>(string url,  DecompressionMethods decompressionMethods, Encoding encoding) where T : class, new()
        {
            return await (await MakeRequest(url, RestMethods.Get, decompressionMethods, encoding)).DeserializeXmlStringAsync<T>();
        }

        public static async Task<HttpResponseMessage> PostObjectToWebApi(string url, string content, Encoding encoding, string mediaType = "application/json")
        {
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(url, new StringContent(content,encoding, mediaType));
                return response;
            }
        }

        private static async Task<string> MakeRequest(string url, RestMethods method, DecompressionMethods methods, Encoding encoding)
        {
            var request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = method.ToString().ToUpper();
            request.AutomaticDecompression = methods;
            using (var response = await request.GetResponseAsync())
            {
                using (var stream = response.GetResponseStream())
                using (var streamReader = new StreamReader(stream ?? throw new InvalidOperationException(), encoding))
                {
                    return await streamReader.ReadToEndAsync();
                }
            }
        }

        public static async Task<HttpResponseMessage> DeleteObjectFromWebApi(string url)
        {
            using (var client = new HttpClient())
            {
                var response = await client.DeleteAsync(url);
                return response;
            }
        }

        public static async Task<HttpResponseMessage> PutObjectToWebApi<T>(string url, T content, Encoding encoding, string mediaType)
        {
            using (var client = new HttpClient())
            {
                var response = await client.PutAsJsonAsync<T>(url, content);

                return response;

            }
        }
    }
}
