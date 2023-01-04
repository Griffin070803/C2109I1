use master
go

drop database if exists C2109I1
create database C2109I1
go

use C2109I1
go

drop table if exists Student
create table Student
(
	Id int primary key identity,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	Gender bit,
	Dob date
)
go

insert into Student(FirstName, LastName, Gender, Dob)
values (N'Nguyễn Hữu', N'Huân', 1, '2003-08-07')
go 10

CREATE PROC GetAllStudent
AS
BEGIN
	SELECT * FROM Student
END
GO

CREATE PROC UpdateStudent
@FirstName NVARCHAR(50), @LastName NVARCHAR(50), @Gender BIT, @Dob DATE, @Id INT
AS
BEGIN
	update Student 
	set FirstName = @FirstName, LastName = @LastName, Gender = @Gender, Dob = @Dob
	where Id = @Id
END
GO
