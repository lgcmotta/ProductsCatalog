using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ProductsCatalog.ConversionExtensions.Json.Deserialize
{
    public static class JsonDeserializeExtensions
    {
        private static readonly JsonSerializerSettings _jsonSerializerSettings = new JsonSerializerSettings
            { ContractResolver = new CamelCasePropertyNamesContractResolver() };
        public static T DeserializeJsonString<T>(this string jsonString) =>
            JsonConvert.DeserializeObject<T>(jsonString
                , _jsonSerializerSettings);

        public static async Task<T> DeserializeJsonStringAsync<T>(this string jsonString) =>
            await Task.Run(() => JsonConvert.DeserializeObject<T>(jsonString));
    }
}