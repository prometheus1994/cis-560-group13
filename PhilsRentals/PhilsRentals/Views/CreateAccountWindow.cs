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
        string firstName;
        string lastName;
        string email;
        string phoneNumber;
        public CreateAccountWindow()
        {
            InitializeComponent();
            
        }
        private void uxButtonAccept_Click(object sender, EventArgs e)
        {
            firstName = uxTextboxFirstName.Text;
            lastName = uxTextboxLastName.Text;
            email = uxTextboxEmail.Text;
            phoneNumber = String.Format("{0:(###) ###-####}", Convert.ToDouble(uxTextboxPhoneNumber.Text));
            MessageBox.Show(phoneNumber);
        }

        private void uxTextboxTextChanged(object sender, EventArgs e)
        {
            uxButtonAccept.Enabled = uxTextboxEmail.TextLength > 0 && uxTextboxFirstName.TextLength > 0 && uxTextboxLastName.TextLength > 0 && uxTextboxPhoneNumber.TextLength == 10;
        }
    }
}