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
        /// Handle to the MainWindowController.
        /// 
        /// This class will only use _mwc.DeleteAccount()
        /// Refer to these methods in the controller for their parameters
        /// These methods need to be implemented
        /// The return types may need to be changed (If you change them you must also change them in the interface)
        /// </summary>
        IMainWindowController _mwc;

        public DeleteAccountWindow(IMainWindowController mwc)
        {
            InitializeComponent();
            _mwc = mwc;
        }

        private void uxTextboxEmail_TextChanged(object sender, EventArgs e)
        {
            if (uxTextboxEmail.Text == "")
            {
                uxButtonAccept.Enabled = false;
            }
            else
                uxButtonAccept.Enabled = true;
        }

        private void uxButtonAccept_Click(object sender, EventArgs e)
        {
            string email = uxTextboxEmail.Text;
        }
    }
}