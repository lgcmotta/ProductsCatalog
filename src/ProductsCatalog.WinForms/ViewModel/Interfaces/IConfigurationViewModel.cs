using System;
using System.Threading.Tasks;
using ProductsCatalog.WinForms.DTO;
using ProductsCatalog.WinForms.DTO.EventArgs;

namespace ProductsCatalog.WinForms.ViewModel.Interfaces
{
    public delegate void ConfigurationLoadedEventHandler(object sender, ConfigurationLoadedEventArgs args);

    public delegate void ConfigurationNotFoundedEventHandler(object sender, ConfigurationNotFoundedEventArgs args);

    public interface IConfigurationViewModel
    {
        event ConfigurationLoadedEventHandler ConfigurationLoaded;

        event ConfigurationNotFoundedEventHandler ConfigurationNotFounded;

        Task<bool> SaveConfiguration(ConfigurationDto configuration);

        void LoadConfiguration();
    }
}