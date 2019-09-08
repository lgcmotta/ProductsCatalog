using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductsCatalog.ConversionExtensions.Json.Serialize;
using ProductsCatalog.ConversionExtensions.Xml.Serialize;
using ProductsCatalog.WinForms.DTO;
using ProductsCatalog.WinForms.DTO.EventArgs;
using ProductsCatalog.WinForms.ViewModel;
using ProductsCatalog.WinForms.ViewModel.Interfaces;

namespace ProductsCatalog.WinForms.Components
{
    public partial class ViewerContainer : System.Windows.Forms.UserControl
    {
        public delegate void ViewerContainerActionEventHandler(object sender, ViewerContainerActionEventArgs args);

        public event ViewerContainerActionEventHandler ViewerContainerActionRequested;

        private readonly IProductsViewModel _productsViewModel;
        private readonly ILogger<ViewerContainer> _logger;

        public ViewerContainer(IProductsViewModel productsViewModel, ILogger<ViewerContainer> logger)
        {
            InitializeComponent();
            _productsViewModel = productsViewModel;
            _logger = logger;
            viewerButtonBar.ViewerButtonClicked += ViewerButtonBarOnButtonClicked;
            productsGridViewer.GridViewerRowSelected += GridViewerOnRowSelected;
            exportButtonBar.ExportButtonClick += ExportButtonOnClick;
        }

        private async Task ExportToFile(ExporButtonEventArgs.Formats fileFormat)
        {
            var products = await _productsViewModel.GetProductsList();

            if (!products.Any())
                return;

            var exported = false;

            switch (fileFormat)
            {
                case ExporButtonEventArgs.Formats.Json:
                    var jsonProducts = await products.ToJsonStringAsync();
                    exported = await OpenSaveFileDialog(jsonProducts,fileFormat);
                    break;
                case ExporButtonEventArgs.Formats.Xml:
                    var xmlProducts = await products.ToList().ToXmlStringAsync();
                    exported = await OpenSaveFileDialog(xmlProducts, fileFormat);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(fileFormat), fileFormat, null);
            }

            if(exported)
            {
                MessageBox.Show($"File successfully exported!", "Success", MessageBoxButtons.OK);

                await _logger.LogInformation(
                    $"Successfully exported {fileFormat} file at {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            }
        }

        private async Task<bool> OpenSaveFileDialog(string fileContent, ExporButtonEventArgs.Formats fileFormats)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                saveFileDialog.Filter = fileFormats == ExporButtonEventArgs.Formats.Json
                    ? "(*.json)|*.json"
                    : "(*.xml)|*.xml";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return false;

                if (string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    MessageBox.Show("File name cannot be empty", "Error", MessageBoxButtons.OK);
                    return false;
                }

                var saved = await _productsViewModel.SaveFile(saveFileDialog.FileName,fileContent);
                return saved;
            }
        }

        private async Task ExportButtonOnClick(object sender, ExporButtonEventArgs args)
        {
            try
            {
                await ExportToFile(args.FileFormat);

                exportButtonBar.ResetFileFormatCheckBoxes();
            }
            catch (Exception exception)
            {
                MessageBox.Show("An unexpected error has occurred.\nPlease see log for more information", "Error"
                    , MessageBoxButtons.OK);

                await _logger.LogException(exception);
            }
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