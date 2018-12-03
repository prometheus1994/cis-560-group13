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
    public partial class BrowseMovieWindow : UserControl, IWindow
    {
        public BrowseMovieWindow()
        {
            InitializeComponent();
        }

        private void uxTextBoxTextChanged(object sender, EventArgs e)
        {
            uxButtonGetMovie.Enabled = uxTextBoxMovieTitle.TextLength > 0;
        }

        private void uxButtonGetMovie_Click(object sender, EventArgs e)
        {
            uxListBoxMovies.Enabled = GetMovies();
            uxTextBoxMovieTitle.Text = "";
        }

        private bool GetMovies()
        {
            return false;
        }

        private void uxListBoxMovies_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}