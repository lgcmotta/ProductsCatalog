namespace ProductsCatalog.WinForms.EventArgs
{
    public class ViewerButtonBarEventArgs : System.EventArgs
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