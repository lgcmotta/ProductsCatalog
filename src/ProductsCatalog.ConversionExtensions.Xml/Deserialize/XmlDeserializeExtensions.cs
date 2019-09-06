using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProductsCatalog.ConversionExtensions.Xml.Deserialize
{
    public static class XmlDeserializeExtensions
    {
        public static T DeserializeXmlString<T>(this string xmlString)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            return (T)xmlSerializer.Deserialize(new StringReader(xmlString));
        }

        public static async Task<T> DeserializeXmlStringAsync<T>(this string xmlString)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            return await Task.Run(() => (T)xmlSerializer.Deserialize(new StringReader(xmlString)));
        }
    }
}