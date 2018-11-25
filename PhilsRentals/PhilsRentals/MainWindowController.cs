using PhilsRentals.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhilsRentals
{
    public class MainWindowController
    {
        /// <summary>
        /// Handle to the MainWindow which is the view for this controller.
        /// </summary>
        private IWindow _view;

        /// <summary>
        /// Dictionary of the operation windows.
        /// </summary>
        private Dictionary<string, IWindow> _windows;

        /// <summary>
        /// Constructs an instance of MainWindowController.
        /// </summary>
        public MainWindowController(Dictionary<string, IWindow> windows)
        {
            _windows = windows;
        }

        /// <summary>
        /// Attach the view its controller.
        /// </summary>
        /// <param name="view"></param>
        public void AttachView(IWindow view)
        {
            _view = view;
        }

        /// <summary>
        /// Operation handler for the view.
        /// </summary>
        public IWindow Handle(string operation)
        {
            /* Code to send window to main window */
            IWindow window;
            _windows.TryGetValue(operation, out window);
            return window;

            // Create a switch for the passed in argument which contains any operation.
            // Call private functions to handle each operation.
        }

        // Create private functions for each different operation.
    }
}