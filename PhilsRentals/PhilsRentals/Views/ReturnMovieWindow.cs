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
    public partial class ReturnMovieWindow : UserControl, IWindow
    {
        public ReturnMovieWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles Returning selected movie(s) from user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxButtonReturnMovie_Click(object sender, EventArgs e)
        {
            
        }
    }
}
