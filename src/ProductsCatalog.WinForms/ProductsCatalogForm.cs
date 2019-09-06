using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductsCatalog.WinForms.DTO;
using ProductsCatalog.WinForms.EventArgs;
using ProductsCatalog.WinForms.ViewModel;

namespace ProductsCatalog.WinForms
{
    public partial class ProductsCatalogForm : Form
    {
        private readonly ConfigurationViewModel _configurationViewModel;

        private readonly ProductsViewModel _productsViewModel;

        public ProductsCatalogForm()
        {
            InitializeComponent();

            _configurationViewModel = new ConfigurationViewModel();

            _productsViewModel = new ProductsViewModel();

            configurationCrud.SaveConfigurationRequested += ConfigurationCrudOnSaveConfigurationRequested;

            mainMenuBar.MainMenuButtonClicked += MainMenuBarOnMainMenuButtonClicked;

            crudContainer.CrudContainerSaveRequested += CrudContainerOnSaveRequested;

            viewerContainer.ViewerContainerActionRequested += ViewerContainerOnActionRequested;
            viewerContainer.ViewerContainerOnRowSelected += ViewerContainerOnRowSelected;

            GetConfiguration();

            RefreshProductsGridViewer();
        }
        
        private void ShowAllProductsContainer()
        {
            viewerContainer.BringToFront();
        }

        private void ShowCrudContainer()
        {
            crudContainer.BringToFront();
        }
        
        private void ResetCrudContainer()
        {
            crudContainer.ResetCrud();
        }

        private void ResetViewerContainer()
        {
            viewerContainer.ResetFileFormatsCheckBoxes();
        }

        private void ShowConfigurationContainer()
        {
            configurationCrud.BringToFront();
        }

        private void GetConfiguration()
        {
            _configurationViewModel.GetConfiguration();

            configurationCrud.SetConfigurationInfo(_configurationViewModel.Configuration);
        }

        private async Task RefreshProductsGridViewer()
        {
            _productsViewModel.Configuration = _configurationViewModel.Configuration;

            await _productsViewModel.RefreshProducts();

            viewerContainer.RefreshGridViewer(_productsViewModel.Products);
        }

        private async Task AddNewProductAsync(CrudContainerEventArgs args)
        {
            var saved = await _productsViewModel.AddNewProduct(args.Product);

            if (!saved)
                return;

            RefreshProductsGridViewer();

            MessageBox.Show($"{args.Product.Name} created!", "Success", MessageBoxButtons.OK);

            ResetCrudContainer();

            _productsViewModel.Operation = ProductsViewModel.CrudOperations.None;

        }

        private async Task RemoveProductAsync(ViewerContainerActionEventArgs args)
        {
            if (_productsViewModel.SelectedProduct == null)
            {
                MessageBox.Show("No product was selected", "Error", MessageBoxButtons.OK);
                return;
            }

            var removed = await _productsViewModel.RemoveProduct(_productsViewModel.SelectedProduct);

            if (!removed)
            {
                MessageBox.Show($"{_productsViewModel.SelectedProduct.Name} could not be removed.", "Error", MessageBoxButtons.OK);
                return ;
            }

            await RefreshProductsGridViewer();

            MessageBox.Show($"{_productsViewModel.SelectedProduct.Name} was removed.", "Success", MessageBoxButtons.OK);
            
        }

        private async Task EditProductAsync(ProductDto product)
        {
            var edited = await _productsViewModel.EditProduct(product);

            if (!edited)
            {
                MessageBox.Show($"{product.Name} could not be edited.", "Error", MessageBoxButtons.OK);
                return ;
            }

            await RefreshProductsGridViewer();

            MessageBox.Show($"{product.Name} was edited.", "Success", MessageBoxButtons.OK);

            _productsViewModel.Operation = ProductsViewModel.CrudOperations.None;
        }
    }

    public partial class ProductsCatalogForm
    {
        private void MainMenuBarOnMainMenuButtonClicked(object sender, MainMenuEventArgs args)
        {
            switch (args.ClickedButton)
            {
                case MainMenuEventArgs.OptionSelected.NewProduct:

                    _productsViewModel.Operation = ProductsViewModel.CrudOperations.Add;
                    
                    ResetCrudContainer();

                    ResetViewerContainer();

                    ShowCrudContainer();

                    break;
                case MainMenuEventArgs.OptionSelected.AllProducts:

                    _productsViewModel.Operation = ProductsViewModel.CrudOperations.Update;

                    ResetCrudContainer();

                    ShowAllProductsContainer();

                    break;
                case MainMenuEventArgs.OptionSelected.Configuration:

                    GetConfiguration();

                    ResetViewerContainer();

                    ResetCrudContainer();

                    ShowConfigurationContainer();

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private async Task ConfigurationCrudOnSaveConfigurationRequested(object sender, ConfigurationCrudEventArgs args)
        {
            try
            {
                var saved = await _configurationViewModel.SaveConfiguration(new ConfigurationDto
                {
                    Host = args.Host
                    , Port = args.Port
                });

                if (saved)
                    MessageBox.Show("Configuration saved.", "Success", MessageBoxButtons.OK);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Save configuration has failed.", "Error", MessageBoxButtons.OK);
                // todo log exception
            }
        }

        private async Task CrudContainerOnSaveRequested(object sender, CrudContainerEventArgs args)
        {
            try
            {
                switch (_productsViewModel.Operation)
                {
                    default:
                    case ProductsViewModel.CrudOperations.None:
                        break;
                    case ProductsViewModel.CrudOperations.Add:
                        await AddNewProductAsync(args);
                        break;
                    case ProductsViewModel.CrudOperations.Update:
                        args.Product.Id = _productsViewModel.SelectedProduct.Id;
                        await EditProductAsync(args.Product);
                        break;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Save new product operation has failed.", "Error", MessageBoxButtons.OK);
                // todo log exception
            }
        }

        private async Task ViewerContainerOnActionRequested(object sender, ViewerContainerActionEventArgs args)
        {
            try
            {
                switch (args.Action)
                {
                    case ViewerContainerActionEventArgs.Buttons.Remove:

                        await RemoveProductAsync(args);

                        break;

                    case ViewerContainerActionEventArgs.Buttons.Edit:

                        _productsViewModel.Operation = ProductsViewModel.CrudOperations.Update;

                        crudContainer.SetProductInfo(_productsViewModel.SelectedProduct);

                        ShowCrudContainer();

                        break;
                    case ViewerContainerActionEventArgs.Buttons.Refresh:

                        await RefreshProductsGridViewer();

                        MessageBox.Show("Poducts list updated!", "Success",MessageBoxButtons.OK);

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{args.Action} failed.", "Error", MessageBoxButtons.OK);
                // todo log exception
            }
        }

        private void ViewerContainerOnRowSelected(object sender, ProductGridEventArgs args)
        {
            _productsViewModel.SelectedProduct = args.Product;
            
        }
    }
}
