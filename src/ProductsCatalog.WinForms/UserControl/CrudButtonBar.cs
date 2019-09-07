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
    public partial class CrudButtonBar : System.Windows.Forms.UserControl
    {
        public delegate Task CrudButtonBarClickEventHandler(object sender, CrudButtonBarEventArgs args);

        public event CrudButtonBarClickEventHandler CrudButtonBarClicked;

        public CrudButtonBar()
        {
            InitializeComponent();
            saveBtn.Click += SaveBtnOnClick;
            cancelBtn.Click += CancelBtnOnClick;
        }

        private void SaveBtnOnClick(object sender, System.EventArgs e)
        {
            CrudButtonBarClicked?.Invoke(sender, new CrudButtonBarEventArgs
            {
                Action = CrudButtonBarEventArgs.ButtonAction.Save
            });
        }

        private void CancelBtnOnClick(object sender, System.EventArgs e)
        {
            CrudButtonBarClicked?.Invoke(sender, new CrudButtonBarEventArgs
            {
                Action = CrudButtonBarEventArgs.ButtonAction.Cancel
            });
        }
    }
}
