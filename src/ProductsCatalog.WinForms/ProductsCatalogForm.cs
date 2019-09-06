using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductsCatalog.WinForms.EventArgs;
using ProductsCatalog.WinForms.ViewModel;

namespace ProductsCatalog.WinForms
{
    public partial class ProductsCatalogForm : Form
    {
        private readonly ConfigurationViewModel _configurationViewModel;
        public ProductsCatalogForm()
        {
            InitializeComponent();
            mainMenuBar.MainMenuButtonClicked += MainMenuBarOnMainMenuButtonClicked;
            _configurationViewModel = new ConfigurationViewModel();
        }

        private void ShowAllProductsContainer()
        {
            viewerContainer.BringToFront();
        }

        private void ShowCrudContainer()
        {
            crudContainer.BringToFront();
        }
        
        private void ResetCrudContainer()
        {
            crudContainer.ResetCrud();
        }

        private void ResetViewerContainer()
        {
            viewerContainer.ResetFileFormatsCheckBoxes();
        }

        private void ShowConfigurationContainer()
        {
            configurationCrud.BringToFront();
        }

        private void MainMenuBarOnMainMenuButtonClicked(object sender, MainMenuEventArgs args)
        {
            switch (args.ClickedButton)
            {
                case MainMenuEventArgs.OptionSelected.NewProduct:
                    ResetViewerContainer();
                    ShowCrudContainer();
                    break;
                case MainMenuEventArgs.OptionSelected.AllProducts:
                    ResetCrudContainer();
                    ShowAllProductsContainer();
                    break;
                case MainMenuEventArgs.OptionSelected.Configuration:
                    ShowConfigurationContainer();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        
    }
}
