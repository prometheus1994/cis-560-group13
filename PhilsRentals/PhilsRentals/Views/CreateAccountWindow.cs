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
            if (uxTextboxFirstName.Text == "" || uxTextboxLastName.Text == "" || uxTextboxPhoneNumber.Text == "" || uxTextboxEmail.Text == "")
            {
                MessageBox.Show("Error: Please Make Sure All Fields Are Filled");
            }
            else
            {
                firstName = uxTextboxFirstName.Text;
                lastName = uxTextboxLastName.Text;
                email = uxTextboxEmail.Text;
                phoneNumber = String.Format("{0:(###) ###-####}", Convert.ToDouble(uxTextboxPhoneNumber.Text));
                MessageBox.Show(phoneNumber);

                
            }
        }
    }
}