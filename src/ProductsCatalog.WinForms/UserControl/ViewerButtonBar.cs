using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductsCatalog.WinForms.EventArgs;

namespace ProductsCatalog.WinForms.UserControl
{
    public partial class ViewerButtonBar : System.Windows.Forms.UserControl
    {
        public delegate void ViewerButtonBarEventHandler(object sender, ViewerButtonBarEventArgs args);

        public event ViewerButtonBarEventHandler ViewerButtonClicked;

        public ViewerButtonBar()
        {
            InitializeComponent();
            refreshBtn.Click += RefreshBtnOnClick;
            removeBtn.Click += RemoveBtnOnClick;
            editBtn.Click += EditBtnOnClick;
        }

        private void RefreshBtnOnClick(object sender, System.EventArgs e)
        {
            ViewerButtonClicked?.Invoke(sender, new ViewerButtonBarEventArgs
            {
                Action = ViewerButtonBarEventArgs.Buttons.Refresh
            });
        }


        private void RemoveBtnOnClick(object sender, System.EventArgs e)
        {
            ViewerButtonClicked?.Invoke(sender, new ViewerButtonBarEventArgs
            {
                Action = ViewerButtonBarEventArgs.Buttons.Remove
            });
        }

        private void EditBtnOnClick(object sender, System.EventArgs e)
        {
            ViewerButtonClicked?.Invoke(sender, new ViewerButtonBarEventArgs
            {
                Action = ViewerButtonBarEventArgs.Buttons.Edit
            });
        }
    }
}
