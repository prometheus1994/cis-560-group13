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

--Modify account:
--1. look up the account using the email and modify the optional parameters: fname, lname, email, phone
drop procedure if exists ModifyAccount 
go
create procedure ModifyAccount
@Email nvarchar(64),
@FirstName nvarchar(256)= null,
@LastName NVARCHAR(32) =null,
@PhoneNumber NVARCHAR(15) =null
AS 
update group13proj.Account 
set FirstName = Coalesce(@FirstName, FirstName),
    LastName = Coalesce(@LastName, LastName),
	PhoneNumber = Coalesce(@PhoneNumber, PhoneNumber)
where Email = @Email
go
--example execution
exec CreateAccount 'John', 'Doe','(373) 234-1333', 'john@idk.com'
select * from group13proj.Account
exec ModifyAccount 'john@idk.com', 'William'
select * from group13proj.Account