﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ProductsCatalog.ConversionExtensions.Json.Serialize;
using ProductsCatalog.HttpRequestManager.Builders;
using ProductsCatalog.HttpRequestManager.Enumerations;
using ProductsCatalog.HttpRequestManager.Extensions;
using ProductsCatalog.HttpRequestManager.ResponseManager;
using ProductsCatalog.WinForms.DTO;
using ProductsCatalog.WinForms.ViewModel.Interfaces;

namespace ProductsCatalog.WinForms.ViewModel.Implementations
{
    public class ProductsViewModel : IProductsViewModel
    {
        private readonly ILogger<ProductsViewModel> _logger;
        private const string Products = "products";
        private const string Api = "api";

        private string _requestBaseUrl;

        public ConfigurationDto Configuration { get; set; }

        public ProductDto SelectedProduct { get; set; }
        
        public ProductsViewModel(ILogger<ProductsViewModel> logger)
        {
            _logger = logger;
            _requestBaseUrl = string.Empty;
        }

        private string GetBaseUrl()
        {
            using (var requestBuilder = new RequestUriBuilder(
                string.Concat(Configuration.Host, ":", Configuration.Port)))
            {
                return requestBuilder.BuildBaseUrl(RequestProtocol.Https)
                    .AppendPath(Api)
                    .Build();
            }
        }

        public async Task<IEnumerable<ProductDto>> GetProductsList()
        {
            _requestBaseUrl = GetBaseUrl().AppendPath(Products);

            return await RequestManager.GetRequestJsonObject<List<ProductDto>>(_requestBaseUrl
                , DecompressionMethods.Deflate | DecompressionMethods.GZip
                , Encoding.UTF8);
        }

        public async Task<bool> AddOrUpdateProduct(ProductDto product)
        {
            if (product.Id == 0)
            {
                _requestBaseUrl = GetBaseUrl()
                    .AppendPath(Products,true);

                await _logger.LogInformation($"Trying to add {product.Name} at {DateTime.Now:yyyy-MM-dd HH:mm:ss}");

                using (var response = await RequestManager.PostObjectToWebApi(_requestBaseUrl, product.ToJsonString(), Encoding.UTF8))
                    return response.StatusCode == HttpStatusCode.Created;
            }

            _requestBaseUrl = GetBaseUrl()
                .AppendPath(Products)
                .AppendPath(product.Id.ToString(), true);

            await _logger.LogInformation($"Trying to update {product.Name} at {DateTime.Now:yyyy-MM-dd HH:mm:ss}");

            using (var response = await RequestManager.PutObjectToWebApi(_requestBaseUrl, product, Encoding.UTF8, "application/json"))
                return response.StatusCode == HttpStatusCode.NoContent;
        }

        public async Task<bool> RemoveProduct(ProductDto product)
        {
            _requestBaseUrl = GetBaseUrl().AppendPath(Products).AppendPath(product.Id.ToString(),true);

            await _logger.LogInformation($"Trying to remove {product.Name} at {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            
            using (var response = await RequestManager.DeleteObjectFromWebApi(_requestBaseUrl))
                return response.StatusCode == HttpStatusCode.NoContent;
        }

        public async Task<bool> SaveFile(string fileName, string fileContent)
        {
            if(File.Exists(fileName))
                File.Delete(fileName);

            await _logger.LogInformation($"Trying to export {fileName} at {DateTime.Now:yyyy-MM-dd HH:mm:ss}");

            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            using (var sw = new StreamWriter(fs))
            {
                await sw.WriteAsync(fileContent);
            }

            return File.Exists(fileName);
        }
    }
}