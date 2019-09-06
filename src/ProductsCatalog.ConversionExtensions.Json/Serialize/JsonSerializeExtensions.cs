using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ProductsCatalog.ConversionExtensions.Json.Serialize
{
    public static class JsonSerializeExtensions
    {
        private static readonly JsonSerializerSettings _jsonSerializerSettings = new JsonSerializerSettings
            { ContractResolver = new CamelCasePropertyNamesContractResolver() };

        public static string ToJsonString<T>(this T jsonObject) where T : class, new() =>
            JsonConvert.SerializeObject(jsonObject
                , _jsonSerializerSettings);

        public static async Task<string> ToJsonStringAsync<T>(this T jsonObject) where T : class, new() =>
            await Task.Run(() => JsonConvert.SerializeObject(jsonObject
                , _jsonSerializerSettings));
    }
}