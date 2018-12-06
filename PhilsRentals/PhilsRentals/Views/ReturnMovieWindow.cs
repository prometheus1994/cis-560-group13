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
    public partial class ReturnMovieWindow : UserControl
    {
        /// <summary>
        /// Handle to get the selected account from the MainWindow.
        /// </summary>
        AccountSelector _GetSelectedAccount;

        /// <summary>
        /// Handle to the MainWindowController.
        /// </summary>
        IMainWindowController _mwc;

        public ReturnMovieWindow(IMainWindowController mwc, AccountSelector GetSelectedAccount)
        {
            InitializeComponent();
            _mwc = mwc;
            _GetSelectedAccount = GetSelectedAccount;
        }

        public void InitWindow()
        {
            uxDataGridViewMovies.Rows.Clear();
            List<Movie> movies = _mwc.GetRentedMovies(_GetSelectedAccount());

            foreach (Movie movie in movies)
            {
                uxDataGridViewMovies.Rows.Add(movie.Title, movie.DueDate);
            }
            uxDataGridViewMovies.ClearSelection();
            uxButtonReturnMovie.Enabled = false;
        }

        /// <summary>
        /// Handles Returning selected movie(s) from user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxButtonReturnMovie_Click(object sender, EventArgs e)
        {
            
        }

        private void uxDataGridViewMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            uxButtonReturnMovie.Enabled = uxDataGridViewMovies.SelectedRows != null;
        }
    }
}