using System.Threading.Tasks;
using ProductsCatalog.WinForms.DTO.EventArgs;

namespace ProductsCatalog.WinForms.Components.UserControl
{
    public partial class ViewerButtonBar : System.Windows.Forms.UserControl
    {
        public delegate Task ViewerButtonBarEventHandler(object sender, ViewerButtonBarEventArgs args);

        public event ViewerButtonBarEventHandler ViewerButtonClicked;

        public ViewerButtonBar()
        {
            InitializeComponent();
            addBtn.Click += AddBtnOnClick;
            refreshBtn.Click += RefreshBtnOnClick;
            removeBtn.Click += RemoveBtnOnClick;
            editBtn.Click += EditBtnOnClick;
        }

        private void AddBtnOnClick(object sender, System.EventArgs e)
        {
            ViewerButtonClicked?.Invoke(sender, new ViewerButtonBarEventArgs
            {
                Action = ViewerButtonBarEventArgs.Buttons.Add
            });
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
