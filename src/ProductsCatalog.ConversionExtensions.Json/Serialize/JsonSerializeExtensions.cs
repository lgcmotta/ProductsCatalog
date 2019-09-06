using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ProductsCatalog.ConversionExtensions.Json.Serialize
{
    public static class JsonSerializeExtensions
    {
        public static string ToJsonString<T>(this T jsonObject) where T : class, new() =>
            JsonConvert.SerializeObject(jsonObject
                , new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                });

        public static async Task<string> ToJsonStringAsync<T>(this T jsonObject) where T : class =>
            await Task.Run(() => JsonConvert.SerializeObject(jsonObject
                , new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                }));
    }
}