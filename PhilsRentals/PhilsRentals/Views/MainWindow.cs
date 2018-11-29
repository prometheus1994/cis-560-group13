﻿using PhilsRentals.Views;
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
        /// Email of the account selected
        /// </summary>
        private string _account = "Select Account";

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
            _menuPanels.Add("Browse Movies", uxPanelBrowseMovie);
            _menuPanels.Add("Rent Movies", uxPanelRentMovie);
            _menuPanels.Add("Create Account", uxPanelCreateAccount);
            _menuPanels.Add("Modify Account", uxPanelModifyAccount);
            _menuPanels.Add("Delete Account", uxPanelDeleteAccount);
            _menuPanels.Add("Add Movie", uxPanelAddMovie);

            /* Start program with default menu */
            uxMenuHandler(uxButtonBrowseMovie, new EventArgs()); // Open default menu
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

            if (!selectedMenu.Equals(_account))
            {
                IWindow window = _operate(selectedMenu);
                if (window != null)
                {
                    Control c = (Control)window;
                    c.Dock = DockStyle.Fill;
                    uxPanelMain.Controls.Add(c);
                }
            }
            else
            {
                if (_account.Equals("Select Account"))
                {
                    string email = GetAccount();
                    if (email.Length > 0 && email.Contains("@"))
                    {
                        uxPanelSelectAccount.Visible = true;
                        uxButtonSelectAccount.Text = email;
                        _account = email;
                        uxButtonRentMovie.Enabled = true;
                    }
                    else
                    {
                        if (email.Length != 0)
                        {
                            MessageBox.Show("Invalid Email");
                        }
                    }

                    uxMenuHandler(uxButtonBrowseMovie, new EventArgs()); // Open default menu
                }
                else
                {
                    uxPanelSelectAccount.Visible = false;
                    uxButtonSelectAccount.Text = "Select Account";
                    _account = "Select Account";
                    uxButtonRentMovie.Enabled = false;
                    uxMenuHandler(uxButtonBrowseMovie, new EventArgs()); // Open default menu
                }
                
            }
        }

        private string GetAccount()
        {
            Form prompt = new Form() {
                BackColor = System.Drawing.Color.White, Width = 350, Height = 150, Text = "Select Account", MaximizeBox = false
            };

            Label textLabel = new Label() { Left = 15, Top = 30, Text = "Email Address:" };
            TextBox inputBox = new TextBox() { Left = 120, Top = 28, Width = 200 };
            Button confirmation = new Button() { Text = "Ok", Left = 222, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);

            DialogResult result = prompt.ShowDialog();
            return (result == DialogResult.Abort) ? "" : inputBox.Text;
        }
    }
}