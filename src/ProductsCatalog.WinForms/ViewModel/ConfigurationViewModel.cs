using System;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProductsCatalog.ConversionExtensions.Json.Deserialize;
using ProductsCatalog.ConversionExtensions.Json.Serialize;
using ProductsCatalog.WinForms.DTO;

namespace ProductsCatalog.WinForms.ViewModel
{
    public class ConfigurationViewModel
    {
        private string _path = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "config.json");

        public ConfigurationDto Configuration { get; set; }

        public ConfigurationViewModel()
        {

        }

        public async Task<bool> SaveConfiguration(ConfigurationDto configuration)
        {
            if(File.Exists(_path))
                File.Delete(_path);

            var jsonConfig = configuration.ToJsonString();

            using (var fs = new FileStream(_path, FileMode.CreateNew, FileAccess.ReadWrite))
            {
                using (var sw = new StreamWriter(fs))
                {
                    await sw.WriteAsync(jsonConfig);
                    return true;
                }
            }
        }

        public ConfigurationDto GetConfiguration()
        {
            if (!File.Exists(_path))
                return null;

            using (var fs = new FileStream(_path, FileMode.Open, FileAccess.Read))
            {
                using (var sr = new StreamReader(fs))
                {
                    var file = sr.ReadToEnd();

                    if (string.IsNullOrEmpty(file))
                        return null;

                    Configuration = file.DeserializeJsonString<ConfigurationDto>();

                    return Configuration;
                }
            }
        }
    }
}