using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductsCatalog.WinForms.DTO;
using ProductsCatalog.WinForms.EventArgs;
using ProductsCatalog.WinForms.ViewModel;

namespace ProductsCatalog.WinForms.Containers
{
    public partial class ViewerContainer : System.Windows.Forms.UserControl
    {
        public delegate void ViewerContainerActionEventHandler(object sender, ViewerContainerActionEventArgs args);

        public event ViewerContainerActionEventHandler ViewerContainerActionRequested;

        private readonly ProductsViewModel _productsViewModel;

        public ViewerContainer()
        {
            InitializeComponent();

            _productsViewModel = new ProductsViewModel();

            viewerButtonBar.ViewerButtonClicked += ViewerButtonBarOnButtonClicked;
            productsGridViewer.GridViewerRowSelected += GridViewerOnRowSelected;
        }

        private void GridViewerOnRowSelected(object sender, ProductGridEventArgs args)
        {
            _productsViewModel.SelectedProduct = args.Product;
        }

        private async Task ViewerButtonBarOnButtonClicked(object sender, ViewerButtonBarEventArgs args)
        {
            switch (args.Action)
            {
                case ViewerButtonBarEventArgs.Buttons.Add:
                case ViewerButtonBarEventArgs.Buttons.Edit:

                    var action = (int)args.Action;

                    _productsViewModel.SelectedProduct = args.Action == ViewerButtonBarEventArgs.Buttons.Add
                        ? null
                        : _productsViewModel.SelectedProduct;

                    ViewerContainerActionRequested?.Invoke(sender, new ViewerContainerActionEventArgs
                    {
                        Action = (ViewerContainerActionEventArgs.Buttons)action,
                        Product = _productsViewModel.SelectedProduct
                    });

                    break;
                case ViewerButtonBarEventArgs.Buttons.Remove:
                    if (_productsViewModel.SelectedProduct == null)
                    {
                        MessageBox.Show($"Please select a product to {args.Action.ToString().ToLower()}"
                            , "Error"
                            , MessageBoxButtons.OK);
                        break;
                    }

                    var removed = await _productsViewModel.RemoveProduct(_productsViewModel.SelectedProduct);

                    MessageBox.Show(removed
                            ? $"{_productsViewModel.SelectedProduct.Name} was removed."
                            : $"{_productsViewModel.SelectedProduct.Name} could not be removed. See log for more information"
                            , removed
                                ? "Success"
                                : "Error", MessageBoxButtons.OK);

                    if (!removed)
                        break;
                    _productsViewModel.SelectedProduct = null;
                    await LoadProductsList();
                    break;
                case ViewerButtonBarEventArgs.Buttons.Refresh:
                    await LoadProductsList();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public async Task<bool> AddOrUpdateProduct(ProductDto product)
        {
            if (_productsViewModel.SelectedProduct != null)
                product.Id = _productsViewModel.SelectedProduct.Id;

            var completed = await _productsViewModel.AddOrUpdateProduct(product);

            return completed;
        }

        public void SetConfiguration(ConfigurationDto configuration)
        {
            _productsViewModel.Configuration = configuration;
        }

        public async Task LoadProductsList()
        {
            var products = await _productsViewModel.GetProductsList();

            productsGridViewer.RefreshGridViewerDataSource(products.ToList());
        }
    }
}