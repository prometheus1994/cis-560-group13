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
    public partial class RentMovieWindow : UserControl
    {
        /// <summary>
        /// Handle to get the selected account from the MainWindow.
        /// </summary>
        AccountSelector _GetSelectedAccount;

        /// <summary>
        /// Handle to the MainWindowController.
        ///
        /// This class will only use _mwc.GetRentableMovies() and _mwc.RentMovie()
        /// Refer to these methods in the controller for their parameters
        /// These methods need to be implemented
        /// The return types may need to be changed (If you change them you must also change them in the interface)
        ///
        /// Use _GetSelectedAccount to get selected email
        /// </summary>
        IMainWindowController _mwc;

        public RentMovieWindow(IMainWindowController mwc, AccountSelector GetSelectedAccount)
        {
            InitializeComponent();
            _mwc = mwc;
            _GetSelectedAccount = GetSelectedAccount;
            AddMovies();
        }

        //not working yet, the information is coming in from the database but not being displayed right within the listbox
        private void AddMovies()
        {
            List<Movie> movies = new List<Movie>();
            movies = _mwc.initDisp();
            foreach (Movie movie in movies)
            {
                uxDataGridViewMovies.Rows.Add(movie.Title, movie.Count);
            }
            uxDataGridViewMovies.CurrentCell = null;
        }

        private void uxDataGridViewMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            uxButtonRentMovie.Enabled = uxDataGridViewMovies.SelectedRows != null;
        }

        private void uxTextBoxMovieTitle_TextChanged(object sender, EventArgs e)
        {
            string search = uxTextBoxMovieTitle.Text.ToLower();
            if (!String.IsNullOrEmpty(search.Trim()))
            {
                for (int i = (uxDataGridViewMovies.Rows.Count - 1); i >= 0; i--)
                {
                    DataGridViewRow row = uxDataGridViewMovies.Rows[i];
                    row.Visible = row.Cells["MovieTitle"].Value.ToString().ToLower().Contains(search);
                    if (row.Visible)
                    {
                        uxDataGridViewMovies.FirstDisplayedScrollingRowIndex = i;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in uxDataGridViewMovies.Rows)
                {
                    row.Visible = true;
                }
                uxDataGridViewMovies.FirstDisplayedScrollingRowIndex = 0;
            }

            uxDataGridViewMovies.ClearSelection();
            uxButtonRentMovie.Enabled = false;
        }

        private void uxButtonRentMovie_Click(object sender, EventArgs e)
        {

        }
    }
}
