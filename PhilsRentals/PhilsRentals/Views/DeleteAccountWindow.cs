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
    public partial class DeleteAccountWindow : UserControl, IWindow
    {
        public IMainWindowController mwc = new MainWindowController();
        public DeleteAccountWindow()
        {
            InitializeComponent();
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
            if (mwc.DeleteAccount(email))
                MessageBox.Show("Account Deleted Successfully.");
            else
                MessageBox.Show("There was an error deleting the account");
            uxTextboxEmail.Text = "";
            uxButtonAccept.Enabled = false;
        }
    }
}