using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductsCatalog.WinForms.DTO;
using ProductsCatalog.WinForms.DTO.EventArgs;

namespace ProductsCatalog.WinForms.Components
{
    public partial class CrudContainer : System.Windows.Forms.UserControl
    {
        public delegate Task CrudContainerSaveEventHandler(object sender, CrudContainerEventArgs args);

        public event CrudContainerSaveEventHandler CrudContainerSaveRequested;

        public CrudContainer()
        {
            InitializeComponent();
            crudButtonBar.CrudButtonBarClicked += CrudButtonBarOnCrudButtonBarClicked;
            
        }

        private bool ValidateProductFields()
        {
            if (!string.IsNullOrEmpty(productCrud.NameText)
                && !string.IsNullOrEmpty(productCrud.DescriptionText))
                return true;

            var sb = new StringBuilder();

            if (string.IsNullOrEmpty(productCrud.NameText))
                sb.AppendLine("- Product must have a name.");
            if (string.IsNullOrEmpty(productCrud.DescriptionText))
                sb.AppendLine("- Product must have a description");

            MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK);

            return false;

        }

        private async Task CrudButtonBarOnCrudButtonBarClicked(object sender, CrudButtonBarEventArgs args)
        {
            switch (args.Action)
            {
                case CrudButtonBarEventArgs.ButtonAction.Save:

                    if (!ValidateProductFields())
                        return;

                    CrudContainerSaveRequested?.Invoke(sender, new CrudContainerEventArgs
                    {
                        Product = new ProductDto
                        {
                            Name = productCrud.NameText,
                            Description = productCrud.DescriptionText,
                            Price = productCrud.PriceValue,
                            Quantity = productCrud.QuantityValue
                        }
                    });

                    break;
                case CrudButtonBarEventArgs.ButtonAction.Cancel:
                    ResetCrud();
                    SendToBack();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void SetProductInfo(ProductDto product)
        {
            if (product == null)
                return;

            productCrud.SetProductInfo(product);
        }

        public void ResetCrud()
        {
            productCrud.ResetCrud();
        }

    }
}
