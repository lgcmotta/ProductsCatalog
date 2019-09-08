namespace ProductsCatalog.WinForms.DTO.EventArgs
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