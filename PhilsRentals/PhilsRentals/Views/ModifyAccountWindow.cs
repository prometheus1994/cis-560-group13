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
    public partial class ModifyAccountWindow : UserControl, IWindow
    {
        public ModifyAccountWindow()
        {
            InitializeComponent();
        }

        private void uxButtonUpdateInfo_Click(object sender, EventArgs e)
        {

        }

        private void uxTextBoxTextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Name.Equals(uxTextBoxSearchEmail.Name))
            {
                uxButtonSearchEmail.Enabled = uxTextBoxSearchEmail.TextLength > 0;
            }
            else
            {
                uxButtonUpdateInfo.Enabled = uxTextBoxFirstName.TextLength > 0 || uxTextBoxLastName.TextLength > 0 || uxTextBoxNewEmail.TextLength > 0 || uxTextBoxPhoneNumber.TextLength == 10;
            }
        }

        private void uxButtonSearchEmail_Click(object sender, EventArgs e)
        {
            uxTextBoxFirstName.Enabled = true;
            uxTextBoxLastName.Enabled = true;
            uxTextBoxNewEmail.Enabled = true;
            uxTextBoxNewEmail.Text = uxTextBoxSearchEmail.Text;
            uxTextBoxPhoneNumber.Enabled = true;
        }
    }
}