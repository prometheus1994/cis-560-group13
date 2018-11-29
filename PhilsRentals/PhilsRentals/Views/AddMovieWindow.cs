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
    public partial class AddMovieWindow : UserControl, IWindow
    {
        public AddMovieWindow()
        {
            InitializeComponent();
        }

        private void uxFieldsChanged(object sender, EventArgs e)
        {
            uxButtonAddMovie.Enabled = uxTextBoxMovieTitle.TextLength > 0 && uxCheckedListBoxMovieGenre.CheckedIndices.Count > 0 && uxNumericUpDownDuration.Value != 0;
        }

        //Ignore the formatting for all of this. Waiting to learn how Rida needs the data. 
        private void uxButtonAddMovie_Click(object sender, EventArgs e)
        {
            string[] movieInformation = new string[5];

            movieInformation[0] = uxTextBoxMovieTitle.ToString();
            movieInformation[2] = uxNumericUpDownYear.ToString();
            movieInformation[3] = uxNumericUpDownYear.ToString();
            movieInformation[4] = uxNumericUpDownRating.ToString();

            int[] genreArray = new int[21];
            int count = 0;
            foreach (int indexChecked in uxCheckedListBoxMovieGenre.CheckedIndices)
            {
                genreArray[count] = indexChecked + 1;
                count++;
            }

            MessageBox.Show(movieInformation[1]);
        }        
    }
}