using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhilsRentals
{
    /// <summary>
    /// Delegate for MainWindowController operations.
    /// </summary>
    public delegate void OperationHandler();

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainWindowController mwc = new MainWindowController(); // Create controller
            MainWindow mw = new MainWindow(mwc.Handle); // Create view with controller operation handler
            mwc.AttachView(mw); // Attach view to controller

            Application.Run(mw);
        }
    }
}
