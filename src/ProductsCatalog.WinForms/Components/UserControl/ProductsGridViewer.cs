using System.Collections.Generic;
using System.Windows.Forms;
using ProductsCatalog.WinForms.DTO;
using ProductsCatalog.WinForms.DTO.EventArgs;

namespace ProductsCatalog.WinForms.Components.UserControl
{
    public partial class ProductsGridViewer : System.Windows.Forms.UserControl
    {
        public delegate void ProductGridSelectedEventHandler(object sender, ProductGridEventArgs args);

        public event ProductGridSelectedEventHandler GridViewerRowSelected;

        public ProductsGridViewer()
        {
            InitializeComponent();
            gridViewer.CellClick += GridViewerOnCellClick;
            gridViewer.DataSourceChanged += GridViewerOnDataSourceChanged;
        }

        private void GridViewerOnDataSourceChanged(object sender, System.EventArgs e)
        {
            gridViewer.ClearSelection();
        }

        private void GridViewerOnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = gridViewer.SelectedRows[0];

            if (row.DataBoundItem is ProductDto product)
                GridViewerRowSelected?.Invoke(sender, new ProductGridEventArgs
                {
                    Product = product
                });
        }

        public void RefreshGridViewerDataSource(List<ProductDto> products)
        {
            gridViewer.DataSource = products;
        }
    }
}
