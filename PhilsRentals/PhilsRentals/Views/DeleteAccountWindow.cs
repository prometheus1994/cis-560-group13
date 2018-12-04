using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhilsRentals.Views
{
    public partial class DeleteAccountWindow : UserControl
    {
        /// <summary>
        /// Handle to get the selected account from the MainWindow.
        /// </summary>
        AccountSelector _GetSelectedAccount;

        /// <summary>
        /// Handle to the MainWindowController.
        ///
        /// This class will only use _mwc.DeleteAccount()
        /// Refer to these methods in the controller for their parameters
        /// These methods need to be implemented
        /// The return types may need to be changed (If you change them you must also change them in the interface)
        /// </summary>
        IMainWindowController _mwc;

        public DeleteAccountWindow(IMainWindowController mwc, AccountSelector GetSelectedAccount)
        {
            InitializeComponent();
            _mwc = mwc;
            _GetSelectedAccount = GetSelectedAccount;
        }

        private void uxTextboxEmail_TextChanged(object sender, EventArgs e)
        {
            uxButtonAccept.Enabled = uxTextboxEmail.TextLength > 0;
        }

        private void uxButtonAccept_Click(object sender, EventArgs e)
        {
            string email = uxTextboxEmail.Text;

            if (uxTextboxEmail.Text.Equals(_GetSelectedAccount()))
            {
                MessageBox.Show("You cannot delete an account that is currently selected.", "Error");
            }
            else
            {
                if (_mwc.DeleteAccount(email))
                {
                    MessageBox.Show("Account Deleted Successfully.");
                }
                else
                {
                    MessageBox.Show("There was an error deleting the account");
                }
            }

            uxTextboxEmail.Text = String.Empty;
            uxButtonAccept.Enabled = false;
        }
    }
}
