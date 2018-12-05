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
        /// 
        /// This class will only use _mwc.GetRentedMovies() and _mwc.ReturnMovie()
        /// Refer to these methods in the controller for their parameters
        /// These methods need to be implemented
        /// The return types may need to be changed (If you change them you must also change them in the interface)
        /// 
        /// Use _GetSelectedAccount to get selected email
        /// </summary>
        IMainWindowController _mwc;

        public ReturnMovieWindow(IMainWindowController mwc, AccountSelector GetSelectedAccount)
        {
            InitializeComponent();
            _mwc = mwc;
            _GetSelectedAccount = GetSelectedAccount;
        }



        public void AddMovies()
        {
            uxDataGridViewMovies.Rows.Clear();
            List<Movie> movies = new List<Movie>();
            movies = _mwc.GetRentedMovies(_GetSelectedAccount());

            foreach (Movie movie in movies)
            {
                uxDataGridViewMovies.Rows.Add(movie.Title, movie.DueDate);
            }
            uxDataGridViewMovies.ClearSelection();
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





        private void uxDataGridViewMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }
    }
}
