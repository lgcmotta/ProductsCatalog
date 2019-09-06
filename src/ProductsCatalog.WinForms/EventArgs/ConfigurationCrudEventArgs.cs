namespace ProductsCatalog.WinForms.EventArgs
{
    public class ConfigurationCrudEventArgs : System.EventArgs
    {
        public string Host { get; set; }

        public int Port { get; set; }
    }
}