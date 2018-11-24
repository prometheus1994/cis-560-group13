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
        private IMainWindow _view;

        /// <summary>
        /// Constructs an instance of MainWindowController.
        /// </summary>
        public MainWindowController()
        {

        }

        /// <summary>
        /// Attach the view its controller.
        /// </summary>
        /// <param name="view"></param>
        public void AttachView(IMainWindow view)
        {
            _view = view;
        }

        /// <summary>
        /// Operation handler for the view.
        /// </summary>
        public void Handle()
        {
            // Create a switch for the passed in argument which contains any operation.
            // Call private functions to handle each operation.
        }

        // Create private functions for each different operation.
    }
}