using ProductsCatalog.WinForms.DTO;

namespace ProductsCatalog.WinForms.EventArgs
{
    public class ConfigurationLoadedEventArgs : System.EventArgs
    {
        public ConfigurationDto Configuration { get; set; }

    }
}