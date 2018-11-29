--Add movies:
--1. Adding a movie to the moviesTable: title, year, rating, genre, star rating, duration
drop procedure if exists AddMovie
go
CREATE PROCEDURE AddMovie
   @MovieName nvarchar(256),
   @Year DateTime,
   @duration int,
   @rating float,
   @genreID nvarchar(100)
AS
Insert group13proj.Movie(MovieTitle, ReleaseYear, Duration, Rating, GenreID)
values(@MovieName, @Year, @duration, @rating,@genreID)
GO
--example execution
exec AddMovie 'Chucky 3', '2018', '123', '3.4', '12,13,3'
select * from group13proj.Movie

--Create account: 
--1. EMployee enters in the fname, lname, email, phone
Drop Procedure if exists CreateAccount
go
CREATE PROCEDURE CreateAccount
   @FirstName nvarchar(32),
   @LastName NVARCHAR(32),
   @PhoneNumber NVARCHAR(15),
   @Email NVARCHAR(64)
AS
Insert group13proj.Account(FirstName, LastName, PhoneNumber, Email)
values(@FirstName, @LastName, @PhoneNumber, @Email)
GO

--example execution:
EXEC CreateAccount'John', 'Doe', '(322) 343-4334' ,'john@idk.com';
select* from group13proj.Account

--Delete account:
--1. ask for email and check if any rentals are due. if yes, dont delete, otherwise delete from database
drop procedure if exists DeleteAccount
go
CREATE PROCEDURE DeleteAccount
   @Email NVARCHAR(64)
AS
Delete A
from group13proj.Account A
where A.Email = @Email
--example execution
exec DeleteAccount 'john@idk.com'
select * from group13proj.Account
