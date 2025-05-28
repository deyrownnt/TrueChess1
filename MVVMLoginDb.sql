create database MVVMLoginDb
go
use MVVMLoginDb
go
create table [User]
(
	Id UNIQUEIDENTIFIER primary Key default NEWID(),
	Username nvarchar (50) unique not null,
	[Password] nvarchar (100) not null,
	[Name]nvarchar (50) not null,
	LastName nvarchar (50) not null,
	Email  nvarchar (100) unique not null
)
go
insert into [User] values (NEWID(), 'admin', 'admin','Deyrownnt','Advance', 'deyrownnt@gmail.com')
insert into [User] values (NEWID(), 'cristi', 'Cristianos','Cristian','Girban', 'cristiangirban@gmail.com')
insert into [User] values (NEWID(), 'keni', 'asdfg','Kenisha Aira','Montero', 'keni.m@gmail.com')
go

select *from [User]