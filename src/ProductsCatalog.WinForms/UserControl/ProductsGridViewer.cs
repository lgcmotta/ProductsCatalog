using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductsCatalog.HttpRequestManager.Enumerations;
using ProductsCatalog.HttpRequestManager.ResponseManager;
using ProductsCatalog.WinForms.DTO;

namespace ProductsCatalog.WinForms.UserControl
{
    public partial class ProductsGridViewer : System.Windows.Forms.UserControl
    {
        public ProductsGridViewer()
        {
            InitializeComponent();
            GetProducts().GetAwaiter();
        }

        private async Task GetProducts()
        {
            try
            {
                var products = await ResponseManager.BuildWebJsonObject<List<ProductDto>>("https://localhost:44336/api/products/"
                    ,RestMethods.Get, DecompressionMethods.GZip | DecompressionMethods.Deflate, Encoding.UTF8);
                PopulateGrid(products);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        public void PopulateGrid(IEnumerable<ProductDto> products)
        {
            gridViewer.DataSource = products;
        }
    }
}
