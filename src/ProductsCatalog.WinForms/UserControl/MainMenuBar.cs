using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductsCatalog.WinForms.EventArgs;

namespace ProductsCatalog.WinForms.UserControl
{
    public partial class MainMenuBar : System.Windows.Forms.UserControl
    {
        public delegate void MainMenuClickEventHandler(object sender, MainMenuEventArgs args);

        public event MainMenuClickEventHandler MainMenuButtonClicked;

        public MainMenuBar()
        {
            InitializeComponent();
            newProductBtn.Click += NewProductBtnOnClick;
            allProductsBtn.Click += AllProductsBtnOnClick;
            configBtn.Click += ConfigBtnOnClick;
        }

        private void ConfigBtnOnClick(object sender, System.EventArgs e)
        {
            MainMenuButtonClicked?.Invoke(sender
                , new MainMenuEventArgs {ClickedButton = MainMenuEventArgs.OptionSelected.Configuration});
        }

        private void AllProductsBtnOnClick(object sender, System.EventArgs e)
        {
            MainMenuButtonClicked?.Invoke(sender
                , new MainMenuEventArgs {ClickedButton = MainMenuEventArgs.OptionSelected.AllProducts});
        }

        private void NewProductBtnOnClick(object sender, System.EventArgs e)
        {
            MainMenuButtonClicked?.Invoke(sender
                , new MainMenuEventArgs { ClickedButton = MainMenuEventArgs.OptionSelected.NewProduct });
        }
    }
    
}
