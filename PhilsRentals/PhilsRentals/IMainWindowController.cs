using PhilsRentals.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhilsRentals
{
    public interface IMainWindowController
    {
        /// <summary>
        /// Gets the form window for a given operation.
        /// </summary>
        /// <param name="operation">Operation name</param>
        /// <returns>Form window to display</returns>
        //IWindow GetOperationWindow(string operation);    just commenting out to test

        /// <summary>
        /// calls the stored procedure to add a movie to the inventory.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="releaseYear"></param>
        /// <returns></returns>
        bool AddInventory(string title, int releaseYear);

        /// <summary>
        /// checks the database when adding a movie to see if the movie already exists in the database
        /// </summary>
        /// <param name="title"></param>
        /// <param name="releaseYear"></param>
        /// <returns></returns>
        bool checkAddMovie(string title, int releaseYear);

        /// <summary>
        /// used to set up the initial display for the rent movie window
        /// </summary>
        /// <returns></returns>
        List<Movie> initDisp();

        /// <summary>
        /// Adds a movie to the database.
        /// </summary>
        /// <param name="title">Title of the movie</param>
        /// <param name="genres">Genres of the movie</param>
        /// <param name="releaseYear">Release year of the movie</param>
        /// <param name="duration">Duration of the movie</param>
        /// <param name="rating">Rating of the movie</param>
        /// <returns>Whether the movie was added successfully or not</returns>
        bool AddMovie(string title, string genres, int releaseYear, int duration, double rating);

        /// <summary>
        /// Gets movies that match the provided filters
        /// </summary>
        /// <param name="title">Title of the movie</param>
        /// <param name="genres">Genres of the movie</param>
        /// <param name="releaseYear">Release year of the movie</param>
        /// <param name="duration">Duration of the movie</param>
        /// <param name="rating">Rating of the movie</param>
        /// <returns>Movies that matched the filters</returns>
        List<string> GetMovies(string title, string genres, int releaseYear, char operationDuration, int duration, char operationRating, float rating);

        /// <summary>
        /// Create an account in the database.
        /// </summary>
        /// <param name="firstName">First name of the account</param>
        /// <param name="lastName">Last name of the account</param>
        /// <param name="phoneNumber">Phone number of the account</param>
        /// <param name="email">Email address of the account</param>
        /// <returns>Whether the account was added successfully or not</returns>
        bool CreateAccount(string firstName, string lastName, string phoneNumber, string email);

        /// <summary>
        /// Delete an account from the database.
        /// </summary>
        /// <param name="email">Email of the account</param>
        /// <returns>Whether the account was deleted successfully or not</returns>
        bool DeleteAccount(string email);

        /// <summary>
        /// Gets account information for a given email address.
        /// </summary>
        /// <param name="email">Email address</param>
        /// <returns>List of account information</returns>
        string[] GetAccountInformation(string email);

        /// <summary>
        /// Modifys the selected account with the information provided.
        /// </summary>
        /// <param name="email">Modified email address</param>
        /// <param name="phoneNumber">Modified phone number</param>
        /// <param name="firstName">Modified first name</param>
        /// <param name="lastName">Modified last name</param>
        /// <returns>Whether the modification was successful or not</returns>
        bool ModifyAccountInformation(string OldEmail, string NewEmail, string phoneNumber, string firstName, string lastName);

        /// <summary>
        /// Gets all rentable movies in inventory.
        /// </summary>
        /// <returns>Rentable movies and their inventory counts</returns>
        List<string> GetRentableMovies();

        /// <summary>
        /// Rents a movie for a given account.
        /// </summary>
        /// <param name="email">Email of the account</param>
        /// <param name="movieTitle">Title of movie rented</param>
        /// <returns>Whether the rent movie was successful or not</returns>
        bool RentMovie(string email, string movieTitle);

        /// <summary>
        /// Gets the rented movies of an account
        /// </summary>
        /// <param name="email">Email account to get rented movies for</param>
        /// <returns>List of rented movies, rented date and return date</returns>
        List<string> GetRentedMovies(string email);

        /// <summary>
        /// Returns a movie for a given account.
        /// </summary>
        /// <param name="email">Email of the account</param>
        /// <param name="movieTitle">Title of the movie returned</param>
        void ReturnMovie(string email, string movieTitle);
    }
}
