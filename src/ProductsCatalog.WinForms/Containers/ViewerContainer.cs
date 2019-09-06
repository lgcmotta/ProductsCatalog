using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductsCatalog.WinForms.DTO;
using ProductsCatalog.WinForms.EventArgs;

namespace ProductsCatalog.WinForms.Containers
{
    public partial class ViewerContainer : System.Windows.Forms.UserControl
    {
        public delegate Task ViewerContainerActionRequestEventHandler(object sender, ViewerContainerActionEventArgs args);
        
        public event ViewerContainerActionRequestEventHandler ViewerContainerActionRequested;

        public delegate void ViewerContainerItemSelectedEventHandler(object sender, ProductGridEventArgs args);

        public event ViewerContainerItemSelectedEventHandler ViewerContainerOnRowSelected;

        public ViewerContainer()
        {
            InitializeComponent();
            viewerButtonBar.ViewerButtonClicked += ViewerButtonBarOnViewerButtonClicked;
            productsGridViewer.GridViewerOnRowSelected += ProductsGridViewerOnRowSelect;
        }

        private void ProductsGridViewerOnRowSelect(object sender, ProductGridEventArgs args)
        {
            ViewerContainerOnRowSelected?.Invoke(sender, args);
        }

        private void ViewerButtonBarOnViewerButtonClicked(object sender, ViewerButtonBarEventArgs args)
        {
            var action = (int)args.Action;

            ViewerContainerActionRequested?.Invoke(sender, new ViewerContainerActionEventArgs()
            {
                Action = (ViewerContainerActionEventArgs.Buttons)action
            });
        }

        public void ResetFileFormatsCheckBoxes()
        {
            exportButtonBar.ResetFileFormatCheckBoxes();
        }
        
        public void RefreshGridViewer(List<ProductDto> products)
        {
            productsGridViewer.RefreshGridViewerDataSource(products);
        }
    }
}
