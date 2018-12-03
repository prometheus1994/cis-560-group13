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
    public partial class AddMovieWindow : UserControl
    {
        /// <summary>
        /// Handle to the MainWindowController.
        ///
        /// This class will only use _mwc.AddMovie()
        /// Refer to these methods in the controller for their parameters
        /// These methods need to be implemented
        /// The return types may need to be changed (If you change them you must also change them in the interface)
        /// </summary>
        IMainWindowController _mwc;

        public AddMovieWindow(IMainWindowController mwc)
        {
            InitializeComponent();
            _mwc = mwc;
        }

        private void uxFieldsChanged(object sender, EventArgs e)
        {
            uxButtonAddMovie.Enabled = uxTextBoxMovieTitle.TextLength > 0 && uxCheckedListBoxMovieGenre.CheckedIndices.Count > 0 && uxNumericUpDownDuration.Value != 0;
        }

        //Ignore the formatting for all of this. Waiting to learn how Rida needs the data.
        //this part should work now but the sql needs to be fixed in order to test
        private void uxButtonAddMovie_Click(object sender, EventArgs e)
        {
            string movieTitle = uxTextBoxMovieTitle.Text;
            int movieYear = Convert.ToInt32(uxNumericUpDownYear.Value);
            int movieDuration = Convert.ToInt32(uxNumericUpDownDuration.Value);
            double movieRating = Convert.ToDouble(uxNumericUpDownRating.Value);

            string movieGenres = "";
            foreach (int indexChecked in uxCheckedListBoxMovieGenre.CheckedIndices)
            {
                movieGenres += (indexChecked + 1).ToString() + ",";
            }
            movieGenres = movieGenres.Remove(movieGenres.Length - 1);
            bool ret = _mwc.checkAddMovie(movieTitle, movieYear);
            if(ret)
            {
                ret = _mwc.AddInventory(movieTitle, movieYear);
            }
            else
            {
                ret = _mwc.AddMovie(movieTitle, movieGenres, movieYear, movieDuration, movieRating);
            }
            if (ret)
                MessageBox.Show("Process Complete.");
            else
                MessageBox.Show("Process Failed");
        }
    }
}
