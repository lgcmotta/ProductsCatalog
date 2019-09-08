using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductsCatalog.WinForms.ViewModel.Implementations;

namespace ProductsCatalog.WinForms
{
    static class Program
    {
        private static Logger<ProductsCatalogForm> _logger = new Logger<ProductsCatalogForm>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ProductsCatalogForm());
            }
            catch (Exception exception)
            {
                _logger.LogException(exception);;
            }
        }
    }
}
