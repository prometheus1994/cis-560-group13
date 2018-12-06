using PhilsRentals.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace PhilsRentals
{
    public class MainWindowController : IMainWindowController
    {
        /// <summary>
        /// Regex for email validation
        /// </summary>
        public static readonly Regex RegexEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        /// <summary>
        /// Connection string for accessing the database.
        /// </summary>
        private const string _connection = "Server=mssql.cs.ksu.edu;Database=pc6;Trusted_Connection=true";

        public MainWindowController()
        {

        }

        /// <summary>
        /// Adds a movie to the database.
        /// </summary>
        /// <param name="title">Title of the movie</param>
        /// <param name="genres">Genres of the movie</param>
        /// <param name="releaseYear">Release year of the movie</param>
        /// <param name="duration">Duration of the movie</param>
        /// <param name="rating">Rating of the movie</param>
        /// <returns>Whether the movie was added successfully or not</returns>
        public bool AddMovie(string title, string genres, int releaseYear, int duration, double rating)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = _connection;


                    //  Do Work
                    SqlCommand cmd = new SqlCommand("AddMovie", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("MovieName", title);
                    cmd.Parameters.AddWithValue("Year", releaseYear);
                    cmd.Parameters.AddWithValue("duration", duration);
                    cmd.Parameters.AddWithValue("rating", rating);
                    cmd.Parameters.AddWithValue("genreID", genres);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    if (AddInventory(title, releaseYear) != true)
                        throw new Exception();
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// checks the database for the movie based on the given title and releaseYear
        /// </summary>
        /// <param name="title"></param>
        /// <param name="releaseYear"></param>
        /// <returns></returns>
        public bool checkAddMovie(string title, int releaseYear)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = _connection;


                    //  Do Work
                    SqlCommand cmd = new SqlCommand("checkMovie", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Title", title);
                    cmd.Parameters.AddWithValue("Year", releaseYear);


                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                        else
                            return false;
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
           
        }

        /// <summary>
        /// Adds the movie to the inventory table
        /// </summary>
        /// <param name="title"></param>
        /// <param name="releaseYear"></param>
        /// <returns></returns>
        public bool AddInventory(string title, int releaseYear)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = _connection;


                    //  Do Work
                    SqlCommand cmd = new SqlCommand("AddInventory", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Title", title);
                    cmd.Parameters.AddWithValue("Year", releaseYear);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Gets movies that match the provided filters
        /// </summary>
        /// <param name="title">Title of the movie</param>
        /// <param name="genres">Genres of the movie</param>
        /// <param name="releaseYear">Release year of the movie</param>
        /// <param name="duration">Duration of the movie</param>
        /// <param name="rating">Rating of the movie</param>
        /// <returns>Movies that matched the filters</returns>
        public List<string> GetMovies(string title, string genres, int releaseYear, char operationDuration, int duration, char operationRating, float rating)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create an account in the database.
        /// </summary>
        /// <param name="firstName">First name of the account</param>
        /// <param name="lastName">Last name of the account</param>
        /// <param name="phoneNumber">Phone number of the account</param>
        /// <param name="email">Email address of the account</param>
        /// <returns>Whether the account was added successfully or not</returns>
        public bool CreateAccount(string firstName, string lastName, string phoneNumber, string email)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = _connection;


                    //  Do Work
                    SqlCommand cmd = new SqlCommand("CreateAccount", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("FirstName", firstName);
                    cmd.Parameters.AddWithValue("LastName", lastName);
                    cmd.Parameters.AddWithValue("PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("Email", email);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
            
        }

        /// <summary>
        /// Delete an account from the database.
        /// </summary>
        /// <param name="email">Email of the account</param>
        /// <returns>Whether the account was deleted successfully or not</returns>
        public bool DeleteAccount(string email)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = _connection;


                    //  Do Work
                    SqlCommand cmd = new SqlCommand("DeleteAccount", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Email", email);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;

        }

        /// <summary>
        /// Gets account information for a given email address.
        /// </summary>
        /// <param name="email">Email address</param>
        /// <returns>List of account information</returns>
        public string[] GetAccountInformation(string email)
        {
            string[] account_info = new string[5];
            using (SqlConnection conn = new SqlConnection())
            {

                conn.ConnectionString = _connection;

                // procedure to grab the account info
                SqlCommand cmd = new SqlCommand("modAcctLookup", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                cmd.Parameters.AddWithValue("Email", email);


                conn.Open();

                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            account_info[0] = ((reader.GetString(reader.GetOrdinal("Email"))));
                            account_info[1] = (reader["PhoneNumber"].ToString());
                            account_info[2] = (reader["FirstName"].ToString());
                            account_info[3] = (reader["LastName"].ToString());
                        }
                        else
                        {
                            account_info[0] = "error";
                        }
                    }
                }
                catch(Exception e)
                {
                    account_info[0] = "error";
                    conn.Close();
                    return account_info;
                }
                conn.Close();
            }

            return account_info;
        }

        /// <summary>
        /// Modifys the selected account with the information provided.
        /// </summary>
        /// <param name="email">Modified email address</param>
        /// <param name="phoneNumber">Modified phone number</param>
        /// <param name="firstName">Modified first name</param>
        /// <param name="lastName">Modified last name</param>
        /// <returns>Whether the modification was successful or not</returns>
        public bool ModifyAccountInformation(string OldEmail, string NewEmail, string phoneNumber, string firstName, string lastName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = _connection;

                    SqlCommand cmd = new SqlCommand("ModifyAccount", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("NewEmail", NewEmail);
                    cmd.Parameters.AddWithValue("OldEmail", OldEmail);
                    cmd.Parameters.AddWithValue("FirstName", firstName);
                    cmd.Parameters.AddWithValue("LastName", lastName);
                    cmd.Parameters.AddWithValue("PhoneNumber", phoneNumber);

                    conn.Open();

                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// Rents a movie for a given account.
        /// </summary>
        /// <param name="email">Email of the account</param>
        /// <param name="movieTitle">Title of movie rented</param>
        /// <returns>Whether the rent movie was successful or not</returns>
        public string RentMovie(string email, string movieTitle)
        {
            try
            {
                string returnDate = String.Empty;

                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = _connection;

                    SqlCommand cmd = new SqlCommand("rentMovie", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("title", movieTitle);
                    conn.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            returnDate = reader.GetSqlDateTime(reader.GetOrdinal("DueDate")).ToString();
                        }
                        else
                        {
                            return null;
                        }    
                    }
                    conn.Close();
                    return returnDate;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        
        /// <summary>
        /// gets the initial listing of all the movies that are available to be rented in the database
        /// </summary>
        /// <returns>List of movie objects</returns>
        public List<Movie> initDisp()
        {
            string temp = String.Empty;
            List<Movie> movies = new List<Movie>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = _connection;


                //  Do Work
                SqlCommand cmd = new SqlCommand("initDispRental", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                
               
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        temp = (reader.GetString(reader.GetOrdinal("MovieTitle")));
                        movies.Add(new Movie(temp, (reader.GetInt32(reader.GetOrdinal("copies")))));
                    } 
               }
               
                conn.Close();
                return movies;
            }

            
        }

        public bool checkSelectedAccount(string email)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = _connection;

                // procedure to grab the account info
                SqlCommand cmd = new SqlCommand("modAcctLookup", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                cmd.Parameters.AddWithValue("Email", email);


                conn.Open();

                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            conn.Close();
                            return true;
                        }
                        else
                        {
                            conn.Close();
                            return false;
                        }
                    }
                }
                catch (Exception e)
                {

                    conn.Close();
                    return false;
                }
                
            }

            
        }


        /// <summary>
        /// Gets the rented movies of an account
        /// </summary>
        /// <param name="email">Email account to get rented movies for</param>
        /// <returns>List of rented movies, rented date and return date</returns>
        public List<Movie> GetRentedMovies(string email)
        {

            string temp = String.Empty;
            List<Movie> movies = new List<Movie>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = _connection;


                //  Do Work
                SqlCommand cmd = new SqlCommand("acctRentals", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("email", email);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        temp = (reader.GetString(reader.GetOrdinal("MovieTitle")));
                        movies.Add(new Movie(temp, ((DateTime)reader["DueDate"]).ToString("MM/d/yyyy")));
                    }
                }

                conn.Close();
                return movies;
            }
        }

            /// <summary>
            /// Returns a movie for a given account.
            /// </summary>
            /// <param name="email">Email of the account</param>
            /// <param name="movieTitle">Title of the movie returned</param>
            public bool ReturnMovie(string email, string movieTitle)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection())
                    {
                        conn.ConnectionString = _connection;


                        //  Do Work
                        SqlCommand cmd = new SqlCommand("returnRental", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("Email", email);
                        cmd.Parameters.AddWithValue("movieTitle", movieTitle);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                
                    return false;
                }
                return true;
            }
    }
    /// <summary>
    /// This is a class used for displaying information about the movies into the gui
    /// </summary>
    public class Movie
    {
        public string Title { get; set; }
        public int Count { get; set; }
        public string DueDate { get; set; }
        public Movie(string t, int c)
        {
            Title = t;
            Count = c;
        }
        public Movie(string t, string dd)
        {
            Title = t;
            DueDate = dd;
        }
    }

}