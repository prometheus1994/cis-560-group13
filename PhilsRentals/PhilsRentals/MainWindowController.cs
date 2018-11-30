using PhilsRentals.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PhilsRentals
{
    public class MainWindowController
    {

        /// <summary>
        /// Connection string for accessing the database.
        /// </summary>
        private const string _connection = "Server=[server_name];Database=[group13proj];Trusted_Connection=true";

        /// <summary>
        /// Handle to the MainWindow which is the view for this controller.
        /// </summary>
        private IWindow _view;

        /// <summary>
        /// Dictionary of the operation windows.
        /// </summary>
        private Dictionary<string, IWindow> _windows;

        /// <summary>
        /// Constructs an instance of MainWindowController.
        /// </summary>
        public MainWindowController(Dictionary<string, IWindow> windows)
        {
            _windows = windows;
        }

        /// <summary>
        /// Attach the view its controller.
        /// </summary>
        /// <param name="view"></param>
        public void AttachView(IWindow view)
        {
            _view = view;
        }

        /// <summary>
        /// Operation handler for the view.
        /// </summary>
        public IWindow Handle(string operation)
        {
            /* Code to send window to main window */
            IWindow window;
            _windows.TryGetValue(operation, out window);

            // modAcctLookup for ModifyAccountWindow.cs
            List<string> account_info = GetAccountInformation("Put Email Here");

            return window;

            // Create a switch for the passed in argument which contains any operation.
            // Call private functions to handle each operation.
        }

        // Create private functions for each different operation.

        /// <summary>
        /// Gets the Account Info using stored procedure ""
        /// </summary>
        /// <param name="email"></param>
        private List<string> GetAccountInformation(string email)
        {
            List<string> account_info = new List<string>();
            using (SqlConnection conn = new SqlConnection())
            {

                conn.ConnectionString = _connection;

                // procedure to grab the account info
                SqlCommand cmd = new SqlCommand("modAcctLookup", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "Email";
                param.Value = email; // Get Value
                cmd.Parameters.Add(param);

                conn.Open();
                int row_check = cmd.ExecuteNonQuery();
                
                // if the number of rows returned is not 1, then the SQL procedure failed.
                // we only need to grab 1 row because one row represents 1 account.
                if (row_check != 1)
                {
                    throw new Exception("Invalid Procedure Call");
                }

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        account_info.Add(reader["Email"].ToString());
                        account_info.Add(reader["PhoneNumber"].ToString());
                        account_info.Add(reader["FirstName"].ToString());
                        account_info.Add(reader["LastName"].ToString());
                    }
                }
                conn.Close();
            }

            return account_info;
        }
    }
}