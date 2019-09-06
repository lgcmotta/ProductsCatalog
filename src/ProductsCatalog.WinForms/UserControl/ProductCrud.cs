using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsCatalog.WinForms.UserControl
{
    public partial class ProductCrud : System.Windows.Forms.UserControl
    {
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
    }
}
