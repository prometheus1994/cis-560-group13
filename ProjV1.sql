
drop table if exists group13proj.Rental
drop table if exists group13proj.Account
drop table if exists group13proj.Inventory
drop table if exists group13Proj.Movie
drop table if exists group13proj.Genre

drop schema if exists group13proj
go
create schema group13proj
go
create table group13proj.Genre
(
	GenreID int not null identity(1,1) primary key,
	GenreName NVarchar(64) not null
)

--Populating the group13proj.Genre table
insert group13proj.Genre(GenreName)
select Genre
from dbo.GenreTable
select * from group13proj.Genre
order by GenreID asc

create table group13Proj.Movie(
	MovieID int not null identity(1,1) primary key,
	MovieTitle NVARCHAR(255) not null,
	ReleaseYear datetime null,
	Duration int null,
	Rating float,
	GenreID nvarchar(100)  null,
	NumberOfCopies int not null
)

--populating the group13proj.Movie table
insert group13Proj.Movie(MovieTitle, ReleaseYear, Duration, Rating, GenreID, NumberOfCopies)
select MovieTitle, CAST(CAST(CAST(ReleaseYear AS INT) AS VARCHAR(8)) AS DATE), Duration, Rating, Genre_ID_ForMovie, Copies
from dbo.MovieDatabase

select* from group13proj.Movie

create table group13proj.Inventory
(
	InventoryID int not null identity(1,1) primary key,
	MovieID int not null foreign key references group13Proj.movie(movieID),
	Rented int not null default 0
)
--inserting 4 sample rows in the inventory table
insert group13proj.Inventory(MovieID)
select M.MovieID
from group13proj.Movie M
create table group13proj.Account
(
	AccountID int not null identity(1,1) primary key,
	FirstName NVARCHAR(32) not null,
	LastName NVARCHAR(32) not null,
	PhoneNumber NVARCHAR(15) not null,
	Email NVARCHAR(64) not null unique
)
--populating Account
insert group13proj.Account(FirstName, LastName, PhoneNumber, Email)
select FirstName, LastName, Phone, Email
from dbo.Accounts
select* from group13proj.Account

create table group13proj.Rental
(
	RentalID int not null identity(1,1) primary key,
	InventoryID int not null foreign key references group13proj.Inventory(InventoryID),
	RentalDate date not null,
	DueDate date not null,
	AccountID int not null foreign key references group13proj.Account(AccountID),
	)

	
/*insert group13proj.Rental(InventoryID, RentalDate, DueDate, AccountID)
select I.InventoryID, T.RentalDate, T.DueDate, A.AccountID
from 
	(
	values
	('2018-02-21', '2018-02-28', N'Heather', N'Wright', N'Avatar'),
	('2018-04-21', '2018-04-28', N'Evan', N'Bower', N'Spectre'),
	('2018-01-12', '2018-01-28', N'Eric', N'Martin', N'Minions'),
	('2018-07-11', '2018-07-21', N'Olivia', N'Sanderson', N'Unbreakable'),
	('2018-06-21', '2018-06-28', N'Diane', N'Lambert', N'Carriers'),
	('2018-03-03', '2018-03-12', N'Robert', N'Underwood', N'Shaft'),
	('2018-04-21', '2018-04-23', N'Jennifer', N'Baker', N'Black Mass'),
	('2018-05-23', '2018-06-03', N'Oliver', N'Wallace', N'Anastasia'),
	('2018-03-23', '2018-03-28', N'Lisa', N'Avery', N'Domestic Disturbance'),
	('2018-04-23', '2018-04-24', N'Vanessa', N'Marshall', N'Eye See You')
	) T(RentalDate, DueDate, FirstName, LastName, MovieName)
	inner join group13proj.Account A on A.FirstName=T.FirstName and A.LastName=T.LastName
	inner join group13proj.Movie M on M.MovieTitle=T.MovieName
	inner join group13proj.Inventory I on I.MovieID= M.MovieID
go*/
select* from group13proj.Rental

select* from group13proj.Movie
--idk what interesting cases would be, 
--maybe we can show what happens if 2 accounts have the same phone or email
--Or if the due date is before the rentaldate
--or as discussed before, a user tries to rent a movie before returning a certain number 
--of those already in his posession
select * from group13proj.Inventory
