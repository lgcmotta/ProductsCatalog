using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ProductsCatalog.ConversionExtensions.Json.Deserialize
{
    public static class JsonDeserializeExtensions
    {
        public static T DeserializeJsonString<T>(this string jsonString) =>
            JsonConvert.DeserializeObject<T>(jsonString
                , new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                });

        public static async Task<T> DeserializeJsonStringAsync<T>(this string jsonString) =>
            await Task.Run(() => JsonConvert.DeserializeObject<T>(jsonString));
    }
}