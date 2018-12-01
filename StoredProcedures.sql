--Add movies:
--1. Adding a movie to the moviesTable: title, year, rating, genre, star rating, duration
drop procedure if exists AddMovie
go
CREATE PROCEDURE AddMovie
   @MovieName nvarchar(256),
   @Year DateTime,
   @duration int,
   @rating float,
   @genreID nvarchar(100),
   @Copies int
AS
Insert group13proj.Movie(MovieTitle, ReleaseYear, Duration, Rating, GenreID, NumberOfCopies)
values(@MovieName, @Year, @duration, @rating,@genreID, @Copies)
GO
--example execution
exec AddMovie 'Chucky 3', '2018', '123', '3.4', '12,13,3', '2'
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

--Renting movies:
--1. all movies and their number of copies returned
drop procedure if exists ShowMovies
go
create procedure ShowMovies
as
select M.MovieTitle, M.NumberOfCopies
from group13proj.Movie M
go
exec ShowMovies

--function that returns the genreIds as a a table with each id on a separate row
drop function if exists splitString
go
CREATE FUNCTION splitstring ( @stringToSplit VARCHAR(50) )
RETURNS
 @returnList TABLE ([id] [nvarchar] (500))
AS
BEGIN

 DECLARE @name NVARCHAR(255)
 DECLARE @pos INT

 WHILE CHARINDEX(',', @stringToSplit) > 0
 BEGIN
  SELECT @pos  = CHARINDEX(',', @stringToSplit)  
  SELECT @name = SUBSTRING(@stringToSplit, 1, @pos-1)

  INSERT INTO @returnList 
  SELECT @name
  SELECT @stringToSplit = SUBSTRING(@stringToSplit, @pos+1, LEN(@stringToSplit)-@pos)
 END

 INSERT INTO @returnList
 SELECT @stringToSplit

 RETURN
END
go
select * from splitString('2,3,4,5')
--procedure to convert the ids into genre names, each row in the table returned is a genre name
drop procedure if exists genreId2Names
go
create procedure genreId2Names
@IdString nvarchar(100),
@gNames nvarchar(max) output
as
select @gNames= coalesce(@gNames+',','')+isnull(temp.GenreName, '')
from 
(
select distinct G.GenreName
from 
(
	select id
	from splitstring(@IdString)
)temp
inner join group13proj.Genre G on temp.id= G.GenreID
)temp(GenreName)
go
declare @outvar nvarchar(1000);
exec genreId2Names '2,3,5', @outvar output
select @outvar
--@var returns all genre names as a single string



--2. when the employee selects a movie in the list in rental window, display the movie title, rating, year, all info.


 

--3. Renting movies: enters customers email, movie title, no of copies, searches for movies and chooses one at a time, check how many copies available,
--update rentals with user info and movie info, update no of copies. 


--This is the initial display for the rental window, only displays the name of the movie and the number of available copies we have
drop procedure if exists initDispRental
go 

create procedure initDispRental As
Select M.MovieTitle, count(distinct i.InventoryID) as [Number of copies]
from group13proj.Inventory I
	inner join group13proj.Movie M on m.MovieID = i.MovieID
where i.Rented = 0
group by M.MovieTitle
go

exec initDispRental
go

--filtering for the movie name is going to be done on the front end
drop procedure if exists filteredMovieTitle
go
create procedure filteredMovieTitle
@MovieTitle nvarchar(255) = '%'
as
select *
from group13proj.Movie M 
where M.MovieTitle like '%'+@MovieTitle+'%'
go
exec filteredMovieTitle 'vat'

drop procedure if exists filteredDurationBoth
go
create procedure filteredDurationBoth
@OperatorGreater nchar(1),
@OperatorLesser nchar(1),
@durationG int,
@durationL int
as
select *
from group13proj.Movie M
where  @operatorGreater ='>' and M.Duration>@durationG
intersect
select *
from group13proj.Movie M
where @OperatorLesser='<' and M.Duration<@durationL
go
exec filteredDurationBoth @OperatorGreater='>',  @durationG=120, @OperatorLesser='<',  @durationL=170

drop procedure if exists filteredDuration
go
create procedure filteredDuration
@Operator nchar(1),
@duration int
as
select *
from group13proj.Movie M
where  (@Operator ='<' and M.Duration<@duration) or (@Operator ='>' and M.Duration>@duration)
go
exec filteredDuration @Operator='<',  @duration=120
exec filteredDuration @Operator='>',  @duration=120

drop procedure if exists filteredRatingBoth
go
create procedure filteredRatingBoth
@OperatorGreater nchar(1),
@OperatorLesser nchar(1),
@ratingG int,
@ratingL int
as
select *
from group13proj.Movie M
where  @operatorGreater ='>' and M.Rating>@ratingG
intersect
select *
from group13proj.Movie M
where @OperatorLesser='<' and M.Rating<@ratingL
go
exec filteredRatingBoth @OperatorGreater='>',  @ratingG=5, @OperatorLesser='<',  @ratingL=7

drop procedure if exists filteredRating
go
create procedure filteredRating
@Operator nchar(1),
@rating int
as
select *
from group13proj.Movie M
where  (@Operator ='<' and M.Rating<@rating) or (@Operator ='>' and M.Rating>@rating)
go
exec filteredRating @Operator='<',  @rating=5
exec filteredRating @Operator='>',  @rating=8

drop procedure if exists filteredYearBoth
go
create procedure filteredYearBoth
@OperatorGreater nchar(1),
@OperatorLesser nchar(1),
@yearG int,
@yearL int
as
select *
from group13proj.Movie M
where  @operatorGreater ='>' and M.ReleaseYear>@yearG
intersect
select *
from group13proj.Movie M
where @OperatorLesser='<' and M.ReleaseYear<@yearL
go
exec filteredYearBoth @OperatorGreater='>',  @yearG=2000, @OperatorLesser='<',  @yearL=2005

drop procedure if exists filteredYear
go
create procedure filteredYear
@Operator nchar(1),
@year int
as
select *
from group13proj.Movie M
where  (@Operator ='<' and M.ReleaseYear<@year) or (@Operator ='>' and M.ReleaseYear>@year)
go
exec filteredYear @Operator='<',  @year=1999
exec filteredYear @Operator='>',  @year=1998

drop procedure if exists filterGenres
create procedure filterGenres
@listofIds int
as
select *
from group13proj.Movie
where 






drop procedure if exists rentMovie
go 

create procedure rentMovie
@title NVarChar(255), @email NvarChar(64)
as
Insert group13proj.Rental(InventoryID, AccountID)
Select Top(1)
	    I.InventoryID, a.AccountID
from group13proj.Movie M
	inner join group13proj.Inventory I on I.MovieID = M.MovieID and i.Rented = 0
	inner join group13proj.Account A on a.Email = @email
where M.MovieTitle = @title;


declare @rID int = Scope_Identity();

select r.DueDate
from group13proj.Rental r
where r.RentalID = @rID
go







-- in process


go

--looks up a customers information to be displayed in the modify account window
drop procedure if exists modAcctLookup
go
create procedure modAcctLookup
@email Nvarchar(64)
as
select a.Email, a.PhoneNumber, a.FirstName, A.LastName
from group13proj.Account A
where a.Email = @email
go

exec modAcctLookup 'uncle@yahoo.com'
go

--summary of account's rentals to be displayed (don't know if it works yet, need to finish rental)
drop procedure if exists acctRentals
go
create procedure acctRentals
@email nvarchar(64)
as
select m.MovieTitle, r.RentalDate, r.DueDate
from group13proj.Rental R
	inner join ( select a.AccountID
				 from group13proj.Account a
				 where a.Email = @email) acct(acctID) on r.AccountID = acct.acctID
	inner join group13proj.Inventory I on i.InventoryID = r.InventoryID
	inner join group13proj.Movie m on m.MovieID = i.InventoryID
go
