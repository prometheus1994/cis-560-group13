using PhilsRentals.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhilsRentals
{
    public partial class MainWindow : Form, IWindow
    {
        /// <summary>
        /// Operation handler for MainWindowController.
        /// </summary>
        private OperationHandler _operate;

        /// <summary>
        /// Dictionary of menu selection panels.
        /// </summary>
        private Dictionary<string, Panel> _menuPanels = new Dictionary<string, Panel>();

        /// <summary>
        /// Constructs the MainWindow view.
        /// </summary>
        /// <param name="operate">Operation handler for MainWindowController</param>
        public MainWindow(OperationHandler operate)
        {
            InitializeComponent();
            _operate = operate; // Store operation handler
            InitializeUx(); // Initialize Ux
        }

        /// <summary>
        /// Initialize user experience components.
        /// </summary>
        private void InitializeUx()
        {
            /* Add menu selection panels to the dictionary of menu selection panels */
            _menuPanels.Add("Rent Movie", uxPanelRentMovie);
            _menuPanels.Add("Create Account", uxPanelCreateAccount);
            _menuPanels.Add("Modify Account", uxPanelModifyAccount);
            _menuPanels.Add("Delete Account", uxPanelDeleteAccount);
            _menuPanels.Add("Add Movie", uxPanelAddMovie);

            /* Start program with default menu */
            uxMenuHandler(uxButtonRentMovie, new EventArgs()); // Open default menu
        }

        /// <summary>
        /// Handles the event when the user selects a menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMenuHandler(object sender, EventArgs e)
        {
            Button selectedButton = (sender as Button); // Get selected button
            string selectedMenu = selectedButton.Text; // Get selected menu text

            /* Display the selection menu indicator on the selected menu and hide the others */
            foreach (KeyValuePair<string, Panel> kvp in _menuPanels)
            {
                kvp.Value.Visible = kvp.Key.Equals(selectedMenu);
            }

            // Call _operate with operation that needs to be done.
            if (uxPanelMain.Controls.Count > 0)
            {
                uxPanelMain.Controls.RemoveAt(0);
            }

            IWindow window = _operate(selectedMenu);
            if (window != null)
            {
                Control c = (Control)window;
                c.Dock = DockStyle.Fill;
                uxPanelMain.Controls.Add(c);
            }
        }
    }
}