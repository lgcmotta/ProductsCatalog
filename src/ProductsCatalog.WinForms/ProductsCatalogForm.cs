using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductsCatalog.WinForms.EventArgs;

namespace ProductsCatalog.WinForms
{
    public partial class ProductsCatalogForm : Form
    {
        public ProductsCatalogForm()
        {
            InitializeComponent();
            configurationCrud.ConfigurationFounded += ConfigurationFounded;
            mainMenuBar.MainMenuButtonClicked += MainMenuOnButtonClicked;
            viewerContainer.ViewerContainerActionRequested += ViewerContainerOnActionRequested;
            crudContainer.CrudContainerSaveRequested += CrudContainerOnSaveRequested;
            configurationCrud.LoadConfiguration();
        }

        private async Task CrudContainerOnSaveRequested(object sender, CrudContainerEventArgs args)
        {
            var completed = await viewerContainer.AddOrUpdateProduct(args.Product);

            MessageBox.Show(completed
                    ? $"{args.Product.Name} saved!"
                    : $"Failed to save {args.Product.Name}"
                , completed
                    ? "Success"
                    : "Error"
                , MessageBoxButtons.OK);

            if (!completed)
                return;

            crudContainer.SendToBack();
            crudContainer.ResetCrud();

            await viewerContainer.LoadProductsList();
        }

        private void ViewerContainerOnActionRequested(object sender, ViewerContainerActionEventArgs args)
        {
            if(args.Product != null)
                crudContainer.SetProductInfo(args.Product);

            crudContainer.BringToFront();
        }

        private void MainMenuOnButtonClicked(object sender, MainMenuEventArgs args)
        {
            switch (args.SelectedOption)
            {
                case MainMenuEventArgs.Options.Products:
                    viewerContainer.BringToFront();
                    break;
                case MainMenuEventArgs.Options.Configuration:
                    configurationCrud.BringToFront();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private async Task ConfigurationFounded(object sender, ConfigurationLoadedEventArgs args)
        {
            mainMenuBar.EnableProductsButton(true);
            viewerContainer.SetConfiguration(args.Configuration);
            await viewerContainer.LoadProductsList();
        }
    }
}
