using System;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProductsCatalog.WinForms.DTO;

namespace ProductsCatalog.WinForms.ViewModel
{
    public class ConfigurationViewModel
    {
        private string _path = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "config.json");

        public async Task SaveConfiguration(ConfigurationDto configuration)
        {
            var jsonConfig = JsonConvert.SerializeObject(configuration);
            using (var fs = new FileStream(_path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (var sw = new StreamWriter(fs))
                {
                    await sw.WriteAsync(jsonConfig);
                }
            }
        }

        public async Task<ConfigurationDto> GetConfiguration()
        {
            if (!File.Exists(_path))
                return null;

            using (var fs = new FileStream(_path, FileMode.Open, FileAccess.Read))
            {
                using (var sr = new StreamReader(fs))
                {
                    var file = await sr.ReadToEndAsync();

                    if (string.IsNullOrEmpty(file))
                        return null;

                    var configuration = (ConfigurationDto)JsonConvert.DeserializeObject(file);

                    return configuration;
                }
            }
        }
    }
}