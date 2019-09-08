using ProductsCatalog.WinForms.DTO.EventArgs;

namespace ProductsCatalog.WinForms.Components.UserControl
{
    public partial class MainMenuBar : System.Windows.Forms.UserControl
    {
        public delegate void MainMenuClickEventHandler(object sender, MainMenuEventArgs args);

        public event MainMenuClickEventHandler MainMenuButtonClicked;

        public MainMenuBar()
        {
            InitializeComponent();
            allProductsBtn.Click += AllProductsBtnOnClick;
            configBtn.Click += ConfigBtnOnClick;
        }

        private void ConfigBtnOnClick(object sender, System.EventArgs e)
        {
            MainMenuButtonClicked?.Invoke(sender
                , new MainMenuEventArgs {SelectedOption = MainMenuEventArgs.Options.Configuration});
        }

        private void AllProductsBtnOnClick(object sender, System.EventArgs e)
        {
            MainMenuButtonClicked?.Invoke(sender
                , new MainMenuEventArgs {SelectedOption= MainMenuEventArgs.Options.Products});
        }

        public void EnableProductsButton(bool value)
        {
            allProductsBtn.Enabled = value;
        }
    }
    
}
