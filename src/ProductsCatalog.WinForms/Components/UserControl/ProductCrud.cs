using ProductsCatalog.WinForms.DTO;

namespace ProductsCatalog.WinForms.Components.UserControl
{
    public partial class ProductCrud : System.Windows.Forms.UserControl
    {

        public string NameText => nameTextBox.Text;

        public string DescriptionText => descriptionTextBox.Text;

        public decimal PriceValue => priceUpDown.Value;

        public int QuantityValue => (int) quantityUpDown.Value;

        public ProductCrud()
        {
            InitializeComponent();
        }

        public void ResetCrud()
        {
            nameTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
            priceUpDown.Value = 0;
            quantityUpDown.Value = 0;
        }

        public void SetProductInfo(ProductDto product)
        {
            nameTextBox.Text = product.Name;
            descriptionTextBox.Text = product.Description;
            priceUpDown.Value = product.Price;
            quantityUpDown.Value = product.Quantity;
        }
        
    }
}
