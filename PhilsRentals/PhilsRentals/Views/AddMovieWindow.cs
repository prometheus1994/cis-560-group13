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
        private void uxButtonAddMovie_Click(object sender, EventArgs e)
        {
            string movieTitle = uxTextBoxMovieTitle.ToString();
            int movieYear = Convert.ToInt32(uxNumericUpDownYear.Value);
            int movieDuration = Convert.ToInt32(uxNumericUpDownDuration.Value);
            int movieRating = Convert.ToInt32(uxNumericUpDownRating.Value);

            string movieGenres = "";
            foreach (int indexChecked in uxCheckedListBoxMovieGenre.CheckedIndices)
            {
                movieGenres += (indexChecked + 1).ToString() + ",";
            }
            movieGenres = movieGenres.Remove(movieGenres.Length - 1);

            string spInfo = @"Data"; //Final piece needed - possibly...
            var cmd = new SqlCommand("New added movie information", new SqlConnection(spInfo));
            cmd.CommandType = CommandType.Text;
            cmd = new SqlCommand("New added movie information", new SqlConnection(spInfo));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@param1", SqlDbType.Structured).Value = movieTitle;
            cmd.Parameters.Add("@param2", SqlDbType.Structured).Value = movieGenres;
            cmd.Parameters.Add("@param3", SqlDbType.Structured).Value = movieYear;
            cmd.Parameters.Add("@param4", SqlDbType.Structured).Value = movieDuration;
            cmd.Parameters.Add("@param5", SqlDbType.Structured).Value = movieRating;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            MessageBox.Show("Process Complete.");
        }        
    }
}