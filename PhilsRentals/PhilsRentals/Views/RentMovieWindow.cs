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
    public partial class RentMovieWindow : UserControl, IWindow
    {
        public RentMovieWindow()
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