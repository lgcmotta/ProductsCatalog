using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using ProductsCatalog.WinForms.DTO;

namespace ProductsCatalog.WinForms.ViewModel.Interfaces
{
    public interface IProductsViewModel
    {
        ConfigurationDto Configuration { get; set; }

        ProductDto SelectedProduct { get; set; }

        Task<IEnumerable<ProductDto>> GetProductsList();

        Task<bool> AddOrUpdateProduct(ProductDto product);

        Task<bool> RemoveProduct(ProductDto product);

        Task<bool> SaveFile(string fileName, string fileContent);

    }
}