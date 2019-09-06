using ProductsCatalog.WinForms.DTO;

namespace ProductsCatalog.WinForms.EventArgs
{
    public class ProductGridEventArgs : System.EventArgs
    {
        public ProductDto Product { get; set; }
    }
}