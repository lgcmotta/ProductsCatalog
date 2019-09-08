using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductsCatalog.WinForms.DTO.EventArgs;

namespace ProductsCatalog.WinForms.Components.UserControl
{
    public partial class ExportButtonBar : System.Windows.Forms.UserControl
    {
        public delegate Task ExportButtonClickedEventHandler(object sender, ExporButtonEventArgs args);

        public event ExportButtonClickedEventHandler ExportButtonClick;

        private enum Formats
        {
            None,
            Json,
            Xml
        }

        private Formats _fileFormat;

        public ExportButtonBar()
        {
            InitializeComponent();
            jsonButton.CheckedChanged += JsonButtonOnCheckedChanged;
            xmlButton.CheckedChanged += XmlButtonOnCheckedChanged;
            exportBtn.Click += ExportButtonOnClick;
        }

        private void ExportButtonOnClick(object sender, EventArgs e)
        {
            if (_fileFormat == Formats.None)
            {
                MessageBox.Show("No format was selected to export", "Error", MessageBoxButtons.OK);
                return;
            }

            var format = (int) _fileFormat;

            ExportButtonClick?.Invoke(sender, new ExporButtonEventArgs
            {
                FileFormat = (ExporButtonEventArgs.Formats) _fileFormat
            });
        }

        private void XmlButtonOnCheckedChanged(object sender, EventArgs e)
        {
            if (xmlButton.Checked)
                _fileFormat = Formats.Xml;
        }

        private void JsonButtonOnCheckedChanged(object sender, EventArgs e)
        {
            if (jsonButton.Checked)
                _fileFormat = Formats.Json;
        }

        public void ResetFileFormatCheckBoxes()
        {
            jsonButton.Checked = false;
            xmlButton.Checked = false;
            _fileFormat = Formats.None;
        }
    }
}
