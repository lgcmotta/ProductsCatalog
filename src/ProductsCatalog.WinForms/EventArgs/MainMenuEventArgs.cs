namespace ProductsCatalog.WinForms.EventArgs
{
    public class MainMenuEventArgs : System.EventArgs
    {
        public enum Options
        {
            Products,
            Configuration
        }

        public Options SelectedOption { get; set; }

    }
}