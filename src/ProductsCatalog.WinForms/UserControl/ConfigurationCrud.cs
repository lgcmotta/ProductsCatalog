using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductsCatalog.WinForms.DTO;
using ProductsCatalog.WinForms.EventArgs;

namespace ProductsCatalog.WinForms.UserControl
{
    public partial class ConfigurationCrud : System.Windows.Forms.UserControl
    {
        public delegate Task SaveConfigurationEventHandler(object sender, ConfigurationCrudEventArgs args);

        public event SaveConfigurationEventHandler SaveConfigurationRequested;

        public ConfigurationCrud()
        {
            InitializeComponent();

            crudButtonBar.CrudButtonBarClicked += CrudButtonBarOnCrudButtonBarClicked;
        }

        private void CrudButtonBarOnCrudButtonBarClicked(object sender, CrudButtonBarEventArgs args)
        {
            switch (args.Action)
            {
                case CrudButtonBarEventArgs.ButtonAction.Save:

                    if (!ValidateConfigurationValues())
                        return;

                    SaveConfigurationRequested?.Invoke(sender, new ConfigurationCrudEventArgs
                    {
                        Host = hostTextBox.Text,
                        Port = (int)portUpDown.Value
                    });

                    break;
                case CrudButtonBarEventArgs.ButtonAction.Cancel:

                    SendToBack();

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
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

        public void SetConfigurationInfo(ConfigurationDto configuration)
        {
            hostTextBox.Text = configuration.Host;
            portUpDown.Value = configuration.Port;
        }
    }
}
