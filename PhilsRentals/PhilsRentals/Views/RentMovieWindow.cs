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

        private void AddMovies()
        {

        }

        private void uxListBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxNumericUpDownRentCount.Enabled = uxListBoxMovies.SelectedItem != null;
        }

        private void uxListBoxMovies_DoubleClick(object sender, EventArgs e)
        {

        }

        private void uxNumericUpDownRentCount_ValueChanged(object sender, EventArgs e)
        {
            uxButtonRentMovie.Enabled = uxNumericUpDownRentCount.Value > 0;
        }

        private void uxButtonRentMovie_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=[server_name];Database=[database_name];Trusted_Connection=true";
                

                //  Do Work
                SqlCommand cmd = new SqlCommand("AddMovie", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "MovieTitle";
                param.Value = ""; // Get Value
                cmd.Parameters.Add(param);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}