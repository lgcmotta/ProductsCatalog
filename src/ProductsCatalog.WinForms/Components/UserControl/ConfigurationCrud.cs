using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductsCatalog.WinForms.DTO;
using ProductsCatalog.WinForms.DTO.EventArgs;
using ProductsCatalog.WinForms.ViewModel;

namespace ProductsCatalog.WinForms.Components.UserControl
{
    public partial class ConfigurationCrud : System.Windows.Forms.UserControl
    {
        public delegate Task ConfigurationFoundedEventHandler(object sender, ConfigurationLoadedEventArgs args);

        public event ConfigurationFoundedEventHandler ConfigurationFounded;

        private readonly ConfigurationViewModel _configurationViewModel;

        public ConfigurationCrud()
        {
            InitializeComponent();
            _configurationViewModel = new ConfigurationViewModel();
            _configurationViewModel.ConfigurationLoaded += ConfigurationLoaded;
            _configurationViewModel.ConfigurationNotFounded += ConfigurationNotFounded;
            crudButtonBar.CrudButtonBarClicked += CrudButtonBarOnCrudButtonBarClicked;
        }

        private bool ValidateConfigurationValues()
        {
            if (!string.IsNullOrEmpty(hostTextBox.Text) && (int) portUpDown.Value > 0)
                return true;
            var sb = new StringBuilder();

            if (string.IsNullOrEmpty(hostTextBox.Text))
                sb.AppendLine("- You must inform a host");

            if ((int) portUpDown.Value == 0)
                sb.AppendLine("- Port value cannot be 0");
            
            MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK);

            return false;
        }

        private void SetConfigurationInfo(ConfigurationDto configuration)
        {
            hostTextBox.Text = configuration.Host;
            portUpDown.Value = configuration.Port;
        }

        private void ConfigurationNotFounded(object sender, ConfigurationNotFoundedEventArgs args)
        {
            MessageBox.Show(args.Message, "Error", MessageBoxButtons.OK);
            BringToFront();
        }

        private void ConfigurationLoaded(object sender, ConfigurationLoadedEventArgs args)
        {
            if (args.Configuration == null)
                return;

            SetConfigurationInfo(args.Configuration);

            ConfigurationFounded?.Invoke(sender, args);
        }

        private async Task CrudButtonBarOnCrudButtonBarClicked(object sender, CrudButtonBarEventArgs args)
        {
            switch (args.Action)
            {
                case CrudButtonBarEventArgs.ButtonAction.Save:

                    if (!ValidateConfigurationValues())
                        return;

                    var saved = await _configurationViewModel.SaveConfiguration(new ConfigurationDto
                    {
                        Host = hostTextBox.Text,
                        Port = (int)portUpDown.Value
                    });

                    if (saved)
                        _configurationViewModel.LoadConfiguration();

                    break;
                case CrudButtonBarEventArgs.ButtonAction.Cancel:
                    SendToBack();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void LoadConfiguration()
        {
            _configurationViewModel.LoadConfiguration();
        }
    }
}
