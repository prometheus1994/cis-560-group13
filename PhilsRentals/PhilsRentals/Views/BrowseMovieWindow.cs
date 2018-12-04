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
    public partial class BrowseMovieWindow : UserControl
    {
        /// <summary>
        /// Handle to the MainWindowController.
        /// 
        /// This class will only use _mwc.GetMovies()
        /// Refer to these methods in the controller for their parameters
        /// These methods need to be implemented
        /// The return types may need to be changed (If you change them you must also change them in the interface)
        /// </summary>
        IMainWindowController _mwc;

        /// <summary>
        /// The title of the movie if they know it
        /// </summary>
        private string _title = "";

        /// <summary>
        /// The genre from the checked list box
        /// </summary>
        private List<string> _genre = new List<string>();

        /// <summary>
        /// The rating of the movie 
        /// </summary>
        private double _rating = 0.0;

        /// <summary>
        /// The year the movie came out
        /// </summary>
        private int _year = 0001;

        /// <summary>
        /// The duration/length of the movie in minutes
        /// </summary>
        private double _length = 000.00;

        public BrowseMovieWindow(IMainWindowController mwc)
        {
            InitializeComponent();
            _mwc = mwc;
        }

        private void uxTextBoxTextChanged(object sender, EventArgs e)
        {
            // need to add optional conditions
            uxButtonGetMovie.Enabled = uxTextBoxMovieTitle.TextLength > 0;
        }

        private void uxButtonGetMovie_Click(object sender, EventArgs e)
        {
            // Need to call functions/stored procedures to filter movies
            // by optional parameters.
            _title = uxTextBoxMovieTitle.Text;
            foreach(var item in uxCheckedListBoxMovieGenre.CheckedItems)
            {
                _genre.Add(item.ToString());
            }
            _rating = Convert.ToInt32(uxNumericUpDownRating.Value);
            _year = Convert.ToInt32(uxNumericUpDownYear.Value);
            _length = Convert.ToInt32(uxNumericUpDownDuration.Value);
        }

        private bool GetMovies()
        {
            return false;
        }

        private void uxListBoxMovies_DoubleClick(object sender, EventArgs e)
        {

        }

        private void uxCheckedListBoxMovieGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}