using System.Threading.Tasks;
using ProductsCatalog.WinForms.DTO.EventArgs;

namespace ProductsCatalog.WinForms.Components.UserControl
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
