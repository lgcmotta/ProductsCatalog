using ProductsCatalog.HttpRequestManager.Builders;
using ProductsCatalog.WinForms.DTO;

namespace ProductsCatalog.WinForms.ViewModel
{
    public class ProductsViewModel
    {
        private readonly RequestUriBuilder _requestUriBuilder;

        public ProductsViewModel(RequestUriBuilder requestUriBuilder)
        {
            _requestUriBuilder = requestUriBuilder;
        }


        public void AddNewProduct(ProductDto product)
        {

        }
    }
}