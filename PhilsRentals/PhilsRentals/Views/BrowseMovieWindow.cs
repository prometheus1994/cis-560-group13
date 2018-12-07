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
    public enum OperatorValue 
    {
        Equals = '=',
        LessThan = '<'
    };

    public partial class BrowseMovieWindow : UserControl
    {
        /// <summary>
        /// Handle to the MainWindowController.
        /// </summary>
        IMainWindowController _mwc;
        
        /// <summary>
        /// The title of the movie if they know it
        /// </summary>
        private string _title = String.Empty;

        /// <summary>
        /// The genre from the checked list box
        /// </summary>
        private List<string> _genres = new List<string>();

        /// <summary>
        /// The compiled genres
        /// </summary>
        private string _compiledGenres = String.Empty;

        /// <summary>
        /// The rating of the movie 
        /// </summary>
        private double _rating = 0;

        /// <summary>
        /// The year the movie came out
        /// </summary>
        private int _year = 0;

        /// <summary>
        /// The duration/length of the movie in minutes
        /// </summary>
        private double _length = 0;

        public BrowseMovieWindow(IMainWindowController mwc)
        {
            InitializeComponent();
            _mwc = mwc;
            uxButtonGetMovie.Enabled = false;
        }

        private void uxTextBoxTextChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// References StoredProcedures -> allFilters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxButtonGetMovie_Click(object sender, EventArgs e)
        {
            // Need to call functions/stored procedures to filter movies
            // by optional parameters.
            _title = uxTextBoxMovieTitle.Text;
            foreach(var item in uxCheckedListBoxMovieGenre.CheckedItems)
            {
                _genres.Add(item.ToString());
            }
            _rating = Convert.ToInt32(uxNumericUpDownRating.Value);
            _year = Convert.ToInt32(uxNumericUpDownYear.Value);
            _length = Convert.ToInt32(uxNumericUpDownDuration.Value);
            
            FormatData();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCheckedListBoxMovieGenre_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < uxCheckedListBoxMovieGenre.Items.Count; ++i)
            {
                if (i != e.Index)
                {
                    uxCheckedListBoxMovieGenre.SetItemChecked(i, false);
                }
            }
        }

        /// <summary>
        /// Sets the value of the "two" numeric updowns.
        /// </summary>
        /// <param name="current_operator"></param>
        private void SetUpperRangeValue(string current_operator, ref NumericUpDown upper, ref NumericUpDown lower)
        {
            if (current_operator.Equals("="))
            {
                upper.Value = lower.Value;
                upper.Enabled = false;
            }
            else
            {
                upper.Enabled = true;
                upper.Value = lower.Value + 1;
            }
        }

        /// <summary>
        /// Takes in the current operator value and sets it to the next possible value.
        /// </summary>
        /// <param name="current_operator"></param>
        /// <returns></returns>
        private string SetOperatorValue(string current_operator)
        {
            if (current_operator.Equals("="))
            {
                return "<";
            }
            else
            {
                return "=";
            }
        }

        #region Rating
        /// <summary>
        /// Handles changing the operator displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNumericUpDownRatingOperator_Click(object sender, EventArgs e)
        {
            string operate = SetOperatorValue(uxNumericUpDownRatingOperator.Text);
            uxNumericUpDownRatingOperator.Text = operate;
            SetUpperRangeValue(operate, ref uxNumericUpDownRatingTwo, ref uxNumericUpDownRating);
        }

        /// <summary>
        /// Tracks the changing value of uxNumericUpDownRating.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNumericUpDownRating_ValueChanged(object sender, EventArgs e)
        {
            if (uxNumericUpDownRatingOperator.Text.Equals("="))
            {
                uxNumericUpDownRatingTwo.Value = uxNumericUpDownRating.Value;
            }
            else
            {
                uxNumericUpDownRatingTwo.Value = uxNumericUpDownRating.Value + 1;
            }
        }
        #endregion

        #region Year
        /// <summary>
        /// Handles changing the operator displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNumericUpDownYearOperator_Click(object sender, EventArgs e)
        {
            string operate = SetOperatorValue(uxNumericUpDownYearOperator.Text);
            uxNumericUpDownYearOperator.Text = operate;
            SetUpperRangeValue(operate, ref uxNumericUpDownYearTwo, ref uxNumericUpDownYear);
        }

        /// <summary>
        /// Tracks the changing value of uxNumericUpDownYear.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNumericUpDownYear_ValueChanged(object sender, EventArgs e)
        {
            if (uxNumericUpDownYearOperator.Text.Equals("="))
            {
                uxNumericUpDownYearTwo.Value = uxNumericUpDownYear.Value;
            }
            else
            {
                uxNumericUpDownYearTwo.Value = uxNumericUpDownYear.Value + 1;
            }
        }
        #endregion

        #region Length/Duration
        /// <summary>
        /// Handles changing the operator displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNumericUpDownDurationOperator_Click(object sender, EventArgs e)
        {
            string operate = SetOperatorValue(uxNumericUpDownDurationOperator.Text);
            uxNumericUpDownDurationOperator.Text = operate;
            SetUpperRangeValue(operate, ref uxNumericUpDownDurationTwo, ref uxNumericUpDownDuration);
        }

        private void uxNumericUpDownDuration_ValueChanged(object sender, EventArgs e)
        {
            if (uxNumericUpDownDurationOperator.Text.Equals("="))
            {
                uxNumericUpDownDurationTwo.Value = uxNumericUpDownDuration.Value;
            }
            else
            {
                uxNumericUpDownDurationTwo.Value = uxNumericUpDownDuration.Value + 1;
            }
        }

        #endregion

        private void uxCheckedListBoxMovieGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxCheckedListBoxMovieGenre.CheckedItems.Count > 0)
            {
                uxButtonGetMovie.Enabled = true;
            }
            // need to add more cases here 
            else
            {
                uxButtonGetMovie.Enabled = false;
            }
        }

        private bool GetMovies()
        {
            return false;
        }

        private void FormatData()
        {
            if (String.IsNullOrEmpty(_title))
            {
                _title = null;
            }
            if (_genres.Count == 0)
            {
                _genres = null;
            }
            if (_year < 1888)
            {
                _year = 0;// movies weren't made before 1888
            }
            if (_length / 60 < 100)
            {
                _length = 0;//the shortest movie in the world is 100 seconds, _length is in minutes
            }

            // joins all strings from _genres into a single, compiled string seperated by commas
            _compiledGenres = String.Join(",", _genres);

            // pass the values via GetMovies()?
            _mwc.GetMovies(_title, _compiledGenres, _year, '0', Convert.ToInt32(_length), '0', (float)_rating);

        }

    }
}