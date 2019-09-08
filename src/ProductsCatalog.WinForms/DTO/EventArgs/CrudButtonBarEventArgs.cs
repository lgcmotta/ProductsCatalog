namespace ProductsCatalog.WinForms.DTO.EventArgs
{
    public class CrudButtonBarEventArgs : System.EventArgs
    {
        public enum ButtonAction
        {
            Save,
            Cancel
        }

        public ButtonAction Action { get; set; }

    }
}