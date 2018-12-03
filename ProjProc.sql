create procedure group13proj.GenreLookup
	@genre NVARCHAR(64), @genreID int
	AS	go 

Create Procedure Group13proj.MovieLookup
@movieID int, @title nvarChar(225), @year DateTime, @rating float, @genre NVARCHAR(64)
 AS 
   
	select *
	from group13proj.Genre
