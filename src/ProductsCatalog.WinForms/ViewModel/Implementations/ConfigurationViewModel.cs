using System;
using System.IO;
using System.Threading.Tasks;
using ProductsCatalog.ConversionExtensions.Json.Deserialize;
using ProductsCatalog.ConversionExtensions.Json.Serialize;
using ProductsCatalog.WinForms.DTO;
using ProductsCatalog.WinForms.DTO.Enums;
using ProductsCatalog.WinForms.DTO.EventArgs;
using ProductsCatalog.WinForms.ViewModel.Interfaces;

namespace ProductsCatalog.WinForms.ViewModel.Implementations
{
    public class ConfigurationViewModel : IConfigurationViewModel
    {
        private readonly ILogger<ConfigurationViewModel> _logger;

        public event ConfigurationLoadedEventHandler ConfigurationLoaded;

        public event ConfigurationNotFoundedEventHandler ConfigurationNotFounded;

        private string _configurationPath;

        public ConfigurationViewModel(ILogger<ConfigurationViewModel> logger)
        {
            _logger = logger;
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
                    var exists = File.Exists(_configurationPath);
                    if (exists)
                        await _logger.LogInformation(
                            $"Configuration file created at {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                    else
                        await _logger.LogError("Configuration file could not be created", LogCriticality.High);

                    return exists;
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

            _logger.LogError($"Configuration file not founded at {DateTime.Now:yyyy-MM-dd HH:mm:ss}."
                , LogCriticality.High);

            return true;
        }

        private void ConfigurationReadFailed()
        {
            File.Delete(_configurationPath);

            ConfigurationNotFounded?.Invoke(this, new ConfigurationNotFoundedEventArgs
            {
                Message = "Application failed to read the existent configuration file.\nPlease fill the configuration form."
            });

            _logger.LogError(
                $"Application failed to read existent configuration file at {DateTime.Now:yyyy-MM-dd HH:mm:ss}", LogCriticality.High);
        }
        
    }
}