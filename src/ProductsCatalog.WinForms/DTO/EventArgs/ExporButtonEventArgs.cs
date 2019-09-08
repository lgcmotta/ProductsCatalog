namespace ProductsCatalog.WinForms.DTO.EventArgs
{
    public class ExporButtonEventArgs
    {
        public enum Formats
        {
            None,
            Json,
            Xml
        }

        public Formats FileFormat { get; set; }
    }
}