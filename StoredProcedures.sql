--procedures that create new entries in tables
--Add movies:
--1. Adding a movie to the moviesTable: title, year, rating, genre, star rating, duration
drop procedure if exists AddMovie
go
CREATE PROCEDURE AddMovie
   @MovieName nvarchar(256),
   @Year int,
   @duration int,
   @rating float,
   @genreID nvarchar(100)

AS
Insert group13proj.Movie(MovieTitle, ReleaseYear, Duration, Rating, GenreID)
values(@MovieName, @Year, @duration, @rating,@genreID)
GO
--example execution
exec AddMovie 'Chucky 3', '2018', '123', '3.4', '12,13,3'
select * from group13proj.Movie M where M.MovieTitle='Chucky 3'

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
select* from group13proj.Account where FirstName='John' and LastName='Doe'

--Modify account:
--1. look up the account using the email and modify the optional parameters: fname, lname, email, phone
drop procedure if exists ModifyAccount
go
create procedure ModifyAccount
@OldEmail nvarchar(64),
@NewEmail nvarchar(64),
@FirstName nvarchar(256)= null,
@LastName NVARCHAR(32) =null,
@PhoneNumber NVARCHAR(15) =null
AS
update group13proj.Account
set FirstName = Coalesce(@FirstName, FirstName),
    LastName = Coalesce(@LastName, LastName),
	PhoneNumber = Coalesce(@PhoneNumber, PhoneNumber),
	Email = Coalesce(@NewEmail, email)
where Email = @OldEmail
go
--example execution
exec CreateAccount 'John', 'Doe','(373) 234-1333', 'john@idk.com'
select * from group13proj.Account
exec ModifyAccount 'john@idk.com', 'William'
select * from group13proj.Account

--Delete account:
--1. ask for email and check if any rentals are due. if yes, dont delete, otherwise delete from database
drop procedure if exists DeleteAccount
go
CREATE PROCEDURE DeleteAccount
   @Email NVARCHAR(64)
AS
Delete A
from group13proj.Account A
where A.Email = @Email and A.AccountID not in(select R.AccountID from group13proj.Rental R )
go
--example execution
select * from group13proj.Rental 
select * from group13proj.Account where Email='john@idk.com'
exec DeleteAccount 'john@idk.com'
select * from group13proj.Account where Email='john@idk.com'

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


--This is the initial display for the rental window, only displays the name of the movie and the number of available copies we have
drop procedure if exists initDispRental
go

create procedure initDispRental As
Select M.MovieTitle, count(distinct i.InventoryID) as [copies]
from group13proj.Inventory I
	inner join group13proj.Movie M on m.MovieID = i.MovieID
where i.Rented = 0
group by M.MovieTitle
go

exec initDispRental
go



--summary of account's rentals to be displayed (don't know if it works yet, need to finish rental)
drop procedure if exists acctRentals
go
create procedure acctRentals
@email nvarchar(64)
as
select m.MovieTitle, r.RentalDate, r.DueDate
from group13proj.Rental R
	inner join group13proj.Account A on A.Email=@email
	inner join group13proj.Inventory I on i.InventoryID = r.InventoryID
	inner join group13proj.Movie m on m.MovieID = i.MovieID
where R.AccountID=A.AccountID
go


drop procedure if exists movieName2id
go
create procedure movieName2id
@name nvarchar(255)
as
select M.MovieID
from group13proj.Movie M where M.MovieTitle=@name
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


--used to check if a movie already exists in the database when being added.
-- this currently doesn not work which means it cannot properly check the db, i need to sleep on it
drop procedure if exists checkMovie
go
create procedure checkMovie
@Title NvarChar(255),
@Year int
as
Select m.MovieTitle
from group13proj.Movie M
where m.ReleaseYear = @year and m.MovieTitle=@Title
go

exec checkMovie 'Avatar', 2009


drop procedure if exists AddInventory
go
create procedure AddInventory
@Title NvarChar(255),
@Year int
as
Insert group13proj.Inventory(MovieID)
Select m.MovieID
from group13proj.Movie M
where m.MovieTitle = @Title and m.ReleaseYear = @Year
go

select *
from group13proj.Movie i
order by i.MovieID


select *
from group13proj.Inventory i
where i.MovieID = 967

select *
from group13proj.Account
   
--filtering for the movie name is going to be done on the front end

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

DROP TRIGGER IF EXISTS group13proj.tr_InsertingRentals;
GO
CREATE TRIGGER group13proj.tr_InsertingRentals ON group13proj.Rental
AFTER insert
AS
update group13proj.Inventory 
set 
rented = 1
where InventoryID = ( select i.InventoryID
					  from inserted ins
					  inner join group13proj.Inventory i on ins.InventoryID = i.InventoryID
					 )
GO
    
exec rentMovie 'Tangled', 'uncle@yahoo.com'
exec rentMovie 'Avatar', 'uncle@yahoo.com'
exec rentMovie 'Avatar', 'xtang@yahoo.com'
exec rentMovie 'Blackhat', 'kmiller@me.com'
select * from group13proj.Rental
select* from group13proj.Inventory where InventoryID=62
exec movieName2id 'Blackhat'
select*from group13proj.Inventory I where I.MovieID=606
--if all copies of a movie have been rented and the employee tries to rent that movie, 
--the procedure returns no rows. Need a message box to notify the eployee about this
exec acctRentals 'uncle@yahoo.com'
exec acctRentals 'kmiller@me.com'

    
drop procedure if exists returnRental
go
create procedure returnRental
@movieTitle nvarchar(255),
@email nvarchar(150)
as
update I
set Rented = 0
from group13proj.Inventory I
inner join group13proj.Movie M on M.MovieTitle=@movieTitle
where I.MovieID= M.MovieID;
delete R
from group13proj.Rental R
inner join group13proj.Account A on A.Email=@email
inner join group13proj.Movie M on M.MovieTitle=@movieTitle 
inner join group13proj.Inventory I on I.MovieID=M.MovieID 
where R.AccountID=A.AccountID and R.InventoryID=I.InventoryID
go
select * from group13proj.Rental
select movieID from group13proj.Movie where MovieTitle='Avatar'
select* from group13proj.Inventory I where I.MovieID=1
exec acctRentals 'uncle@yahoo.com'
exec returnRental 'Avatar', 'uncle@yahoo.com'
select* from group13proj.Inventory where InventoryID=62
select*from group13proj.Rental

--dont think we need this trigger
DROP TRIGGER IF EXISTS group13proj.tr_DeletingRentals;
GO
CREATE TRIGGER group13proj.tr_DeletingRentals ON group13proj.Rental
AFTER update
AS
delete R
from group13proj.Rental R
inner join group13proj.Inventory I on I.InventoryID = R.InventoryID
GO


/************************************************************************************************************************/
--Filtering stuff
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

--takes one genreId at a time
drop procedure if exists filterGenres
go
create procedure filterGenres
@id nvarchar(50)
as
select *
from group13proj.Movie M
where M.GenreID like '%'+', '+@id+','+'%' or M.GenreID like '%'+ ', '+ @id or M.GenreID like @id+'%'

exec filterGenres '2'


--combined filers

drop procedure if exists allFilters
go
create procedure allfilters
@genreId nvarchar(50)='%',
@duration int='%',
@doperator nchar(1)=null,
@rating float='%',
@roperator nchar(1)=null,
@year int='%',
@yoperator nchar(1)=null,
@movietitle nvarchar(255)='%'
as
select *
from group13proj.Movie M
where M.GenreID like '%'+', '+@genreId+','+'%' and  ((@yoperator ='<' and M.ReleaseYear<@year)
or (@yoperator ='>' and M.ReleaseYear>@year)) and ((@doperator ='<' and M.Duration<@duration)
or (@doperator ='>' and M.Duration>@duration)) and ((@roperator ='<' and M.Rating<@rating)
or (@roperator ='>' and M.Rating>@rating)) and M.MovieTitle like '%'+@movietitle+'%'
go
exec allFilters
@genreId='14',
@duration =120,
@doperator ='>',
@rating = 5.5,
@roperator ='>',
@year =2000,
@yoperator ='>',
@movietitle='vat'
 


 select *
 from group13proj.Rental