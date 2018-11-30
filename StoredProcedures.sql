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
--procedure to convert the ids into genre names, each row in the table returned is a genre name
drop function if exists genreNames
go

create procedure genreNames
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

drop function if exists ff
go
create function ff(@idString nvarchar(100)) returns nvarchar(max)
as
begin
declare @glist nvarchar(max)
exec genreNames @idString, gList
return @glist
end
go
select [dbo].[ff]('1,2,3,4');--doesnt work, need to fix

Declare @var nvarchar(max)
exec genreNames '12,3,4,6' , @var output
select @var
--@var returns all genre names as a single string



--2. when the employee selects a movie in the list, display the movie title, rating, year, all info.
drop procedure if exists SelectedMovie
go 
create procedure SelectedMovie
@MovieName nvarchar(255)
as
declare @var nvarchar(max);
select M.MovieTitle, M.ReleaseYear, M.Duration, M.Rating, 
(
 
 ff(M.GenreID, @var output)--need to fix
 
) as gName
, M.NumberOfCopies
from group13proj.Movie M
where M.MovieTitle=@MovieName
group by M.MovieTitle,  M.ReleaseYear, M.Duration, M.Rating
go
exec SelectedMovie 'Avatar'
go

 

--3. Renting movies: enters customers email, movie title, no of copies, searches for movies and chooses one at a time, check how many copies available,
--update rentals with user info and movie info, update no of copies. 



