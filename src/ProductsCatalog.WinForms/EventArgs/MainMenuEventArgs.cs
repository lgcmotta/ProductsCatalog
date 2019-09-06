namespace ProductsCatalog.WinForms.EventArgs
{
    public class MainMenuEventArgs : System.EventArgs
    {
        public enum OptionSelected
        {
            NewProduct,
            AllProducts,
            Configuration
        }

        public OptionSelected ClickedButton { get; set; }

    }
}