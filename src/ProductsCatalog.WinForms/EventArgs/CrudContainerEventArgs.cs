using ProductsCatalog.WinForms.DTO;

namespace ProductsCatalog.WinForms.EventArgs
{
    public class CrudContainerEventArgs : System.EventArgs
    {
        public ProductDto Product { get; set; }
    }
}