namespace ProductsCatalog.WinForms.DTO.EventArgs
{
    public class ViewerButtonBarEventArgs : System.EventArgs
    {
        public enum Buttons
        {
            Add,
            Edit,
            Remove,
            Refresh
        }

        public Buttons Action { get; set; }
    }
}