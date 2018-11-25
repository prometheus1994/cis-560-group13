using PhilsRentals.Views;
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
    public delegate IWindow OperationHandler(string operation);

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

            /* Create dictionary of all operation windows */
            Dictionary<string, IWindow> windows = new Dictionary<string, IWindow>();
            windows.Add("Rent Movie", new RentMovieWindow());
            windows.Add("Create Account", new CreateAccountWindow());
            windows.Add("Modify Account", new ModifyAccountWindow());
            windows.Add("Delete Account", new DeleteAccountWindow());
            windows.Add("Add Movie", new AddMovieWindow());

            /* Create controller and attach main view */
            MainWindowController mwc = new MainWindowController(windows); // Create controller
            MainWindow mw = new MainWindow(mwc.Handle); // Create view with controller operation handler
            mwc.AttachView(mw); // Attach view to controller

            Application.Run(mw);
        }
    }
}
