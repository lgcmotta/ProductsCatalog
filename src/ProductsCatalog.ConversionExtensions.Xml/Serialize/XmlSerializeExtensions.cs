using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ProductsCatalog.ConversionExtensions.Xml.Serialize
{
    public static class XmlSerializeExtensions
    {
        public static string ToXmlString<T>(this T xmlObject) where T : class
        {
            using (var stringWriter = new StringWriter())
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(stringWriter, xmlObject);
                return stringWriter.ToString();
            }
        }

        public static async Task<string> ToXmlStringAsync<T>(this T xmlObject) where T : class
        {
            using (var stringWriter = new StringWriter())
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                await Task.Run(() => xmlSerializer.Serialize(stringWriter, xmlObject));
                return stringWriter.ToString();
            }
        }
    }
}