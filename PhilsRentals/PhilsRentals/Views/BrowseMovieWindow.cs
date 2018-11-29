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
            AddMovies();
        }

        private void uxTextBoxTextChanged(object sender, EventArgs e)
        {
            uxListBoxMovies.Enabled = uxTextBoxEmailAddress.TextLength > 0;
        }

        private void AddMovies()
        {

        }

        private void uxListBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxNumericUpDownRentCount.Enabled = uxListBoxMovies.SelectedItem != null;
        }

        private void uxNumericUpDownRentCount_ValueChanged(object sender, EventArgs e)
        {
            uxButtonRentMovie.Enabled = uxNumericUpDownRentCount.Value > 0;
        }

        private void uxButtonRentMovie_Click(object sender, EventArgs e)
        {

        }
    }
}