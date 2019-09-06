using System.Collections.Generic;
using System.Drawing.Printing;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ProductsCatalog.ConversionExtensions.Json.Serialize;
using ProductsCatalog.HttpRequestManager.Builders;
using ProductsCatalog.HttpRequestManager.Enumerations;
using ProductsCatalog.HttpRequestManager.Extensions;
using ProductsCatalog.HttpRequestManager.ResponseManager;
using ProductsCatalog.WinForms.DTO;

namespace ProductsCatalog.WinForms.ViewModel
{
    public class ProductsViewModel
    {
        public enum CrudOperations
        {
            None,
            Add,
            Update
        }

        private string _requestBaseUrl;

        public ConfigurationDto Configuration { get; set; }

        public List<ProductDto> Products { get; set; }

        public ProductDto SelectedProduct { get; set; }

        public CrudOperations Operation { get; set; }

        public ProductsViewModel()
        {
            _requestBaseUrl = string.Empty;
        }

        private string GetBaseUrl()
        {
            using (var requestBuilder = new RequestUriBuilder(
                string.Concat(Configuration.Host, ":", Configuration.Port)))
            {
                return requestBuilder.BuildBaseUrl(RequestProtocol.Https)
                    .AppendPath("api")
                    .Build();
            }
        }

        public async Task<bool> AddNewProduct(ProductDto product)
        {
            _requestBaseUrl = GetBaseUrl().AppendPath("products", true);

            var productJsonString = product.ToJsonString();

            var response = await ResponseManager.PostObjectToWebApi(_requestBaseUrl, productJsonString, Encoding.UTF8);

            return response.StatusCode == HttpStatusCode.Created;
        }

        public async Task RefreshProducts()
        {
            _requestBaseUrl = GetBaseUrl().AppendPath("products", true);

            Products = await ResponseManager.GetRequestJsonObject<List<ProductDto>>(_requestBaseUrl
                    , DecompressionMethods.Deflate | DecompressionMethods.GZip, Encoding.UTF8);
        }

        public async Task<bool> RemoveProduct(ProductDto product)
        {
            _requestBaseUrl = GetBaseUrl().AppendPath("products").AppendPath(product.Id.ToString(), true);

            var response = await ResponseManager.DeleteObjectFromWebApi(_requestBaseUrl);

            return response.StatusCode == HttpStatusCode.NoContent;
        }

        public async Task<bool> EditProduct(ProductDto product)
        {
            _requestBaseUrl = GetBaseUrl().AppendPath("products").AppendPath(product.Id.ToString(), true);

            var productJson = product.ToJsonString();

            var response = await ResponseManager.PutObjectToWebApi(_requestBaseUrl, product, Encoding.UTF8, "application/json");

            return response.StatusCode == HttpStatusCode.NoContent;
        }

     
    }
}