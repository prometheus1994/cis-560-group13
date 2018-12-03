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
    public partial class CreateAccountWindow : UserControl, IWindow
    {
        public IMainWindowController mwc = new MainWindowController();
        string firstName;
        string lastName;
        string email;
        string phoneNumber;
        public CreateAccountWindow()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Gathers the information from the text boxes and sends it to the controller to add the account to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxButtonAccept_Click(object sender, EventArgs e)
        {
            firstName = uxTextboxFirstName.Text;
            lastName = uxTextboxLastName.Text;
            email = uxTextboxEmail.Text;
            phoneNumber = String.Format("{0:(###) ###-####}", Convert.ToDouble(uxTextboxPhoneNumber.Text));
            //MessageBox.Show(phoneNumber);
            bool ret = mwc.CreateAccount(firstName, lastName, phoneNumber, email);
            if (ret)
                MessageBox.Show("Account Created Successfully");
            else
                MessageBox.Show("There was a problem creating the account. Please try again.");
            uxTextboxEmail.Text = "";
            uxTextboxFirstName.Text = "";
            uxTextboxLastName.Text = "";
            uxTextboxPhoneNumber.Text = "";
            uxButtonAccept.Enabled = false;
    }

        private void uxTextboxTextChanged(object sender, EventArgs e)
        {
            uxButtonAccept.Enabled = uxTextboxEmail.TextLength > 0 && uxTextboxFirstName.TextLength > 0 && uxTextboxLastName.TextLength > 0 && uxTextboxPhoneNumber.TextLength == 10;
        }
    }
}