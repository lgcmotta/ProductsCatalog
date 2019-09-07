using System;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProductsCatalog.ConversionExtensions.Json.Deserialize;
using ProductsCatalog.ConversionExtensions.Json.Serialize;
using ProductsCatalog.WinForms.DTO;
using ProductsCatalog.WinForms.EventArgs;

namespace ProductsCatalog.WinForms.ViewModel
{
    public class ConfigurationViewModel
    {
        public delegate void ConfigurationLoadedEventHandler(object sender, ConfigurationLoadedEventArgs args);

        public delegate void ConfigurationNotFoundedEventHandler(object sender, ConfigurationNotFoundedEventArgs args);
        
        public event ConfigurationLoadedEventHandler ConfigurationLoaded;

        public event ConfigurationNotFoundedEventHandler ConfigurationNotFounded;

        private string _configurationPath;

        public ConfigurationViewModel()
        {
            _configurationPath = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "config.json");
        }

        public async Task<bool> SaveConfiguration(ConfigurationDto configuration)
        {
            if(File.Exists(_configurationPath))
                File.Delete(_configurationPath);

            var jsonConfig = configuration.ToJsonString();

            using (var fs = new FileStream(_configurationPath, FileMode.CreateNew, FileAccess.ReadWrite))
            {
                using (var sw = new StreamWriter(fs))
                {
                    await sw.WriteAsync(jsonConfig);
                    return File.Exists(_configurationPath);
                }
            }
        }

        public void LoadConfiguration()
        {
            if (HandleConfigurationNotFounded())
                return;

            using (var fs = new FileStream(_configurationPath, FileMode.Open, FileAccess.Read))
            {
                using (var sr = new StreamReader(fs))
                {
                    var file = sr.ReadToEnd();

                    if (string.IsNullOrEmpty(file))
                    {
                        ConfigurationReadFailed();

                        return;
                    }

                    var configuration = file.DeserializeJsonString<ConfigurationDto>();

                    ConfigurationLoaded?.Invoke(this,new ConfigurationLoadedEventArgs
                    {
                        Configuration = configuration
                    });
                }
            }
        }

        private bool HandleConfigurationNotFounded()
        {
            if (File.Exists(_configurationPath))
                return false;

            ConfigurationNotFounded?.Invoke(this, new ConfigurationNotFoundedEventArgs
            {
                Message = "Configuration not founded.\nPlease fill the configuration form."
            });

            return true;
        }

        private void ConfigurationReadFailed()
        {
            File.Delete(_configurationPath);

            ConfigurationNotFounded?.Invoke(this, new ConfigurationNotFoundedEventArgs
            {
                Message = "Application failed to read the existent configuration file.\nPlease fill the configuration form."
            });
        }

        
    }
}