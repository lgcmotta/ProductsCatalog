using ProductsCatalog.WinForms.DTO;

namespace ProductsCatalog.WinForms.EventArgs
{
    public class ViewerContainerActionEventArgs : System.EventArgs
    {
        public enum Buttons
        {
            Remove,
            Edit,
            Refresh
        }

        public Buttons Action { get; set; }
    }
}