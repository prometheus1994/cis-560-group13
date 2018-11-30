using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhilsRentals.Views
{
    public partial class ModifyAccountWindow : UserControl, IWindow
    {

        public IMainWindowController mwc = new MainWindowController();
        //public IMainWindowController iWindowController = new IMainWindowController();
        public ModifyAccountWindow()
        {
            InitializeComponent();
        }


        private void uxTextBoxTextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Name.Equals(uxTextBoxSearchEmail.Name))
            {
                uxButtonSearchEmail.Enabled = uxTextBoxSearchEmail.TextLength > 0;
            }
            else
            {
                uxButtonUpdateInfo.Enabled = uxTextBoxFirstName.TextLength > 0 || uxTextBoxPhoneNumber.TextLength > 0 || uxTextBoxNewEmail.TextLength > 0 || uxTextBoxLastName.TextLength == 10;
            }
        }


        /// <summary>
        /// Pulls the customer info from the SQL Tables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxButtonUpdateInfo_Click(object sender, EventArgs e)
        {
            bool ret = mwc.ModifyAccountInformation(uxTextBoxNewEmail.Text, uxTextBoxPhoneNumber.Text, uxTextBoxFirstName.Text, uxTextBoxLastName.Text);
            if(ret)
            {
                MessageBox.Show("Update processed successfully");
            }
            else
            {
                MessageBox.Show("Error With Update");
            }
        }

        /* 
         * create table group13proj.Account
         * 
         * (
	            AccountID int not null identity(1,1) primary key,
	            FirstName NVARCHAR(32) not null,
	            LastName NVARCHAR(32) not null,
	            PhoneNumber NVARCHAR(15) not null,
	            Email NVARCHAR(64) not null unique
            )
         */
        /// <summary>
        /// Looks for the email in the Account table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxButtonSearchEmail_Click(object sender, EventArgs e)
        {
            // [0] = AccountID
            // [1] = FirstName
            // ...
            // [4] = Email
            string email = uxTextBoxSearchEmail.Text.Substring(0, uxTextBoxSearchEmail.Text.Length-2);
            string[] account_info = mwc.GetAccountInformation(email);
            uxTextBoxFirstName.Enabled = true;
            uxTextBoxPhoneNumber.Enabled = true;
            uxTextBoxNewEmail.Enabled = true;
            uxTextBoxNewEmail.Text = uxTextBoxSearchEmail.Text;
            uxTextBoxLastName.Enabled = true;
            uxTextBoxNewEmail.Text = account_info[0];
            uxTextBoxLastName.Text = account_info[3];
            uxTextBoxFirstName.Text = account_info[2];
            uxTextBoxPhoneNumber.Text = account_info[1];
            // grab the existing email from the TextBoxSearchEmail
            // uxTextBoxNewEmail.Text = uxTextBoxSearchEmail.Text;
        }
    }
}
 