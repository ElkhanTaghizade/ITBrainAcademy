--create database Base
--use Base
create table Brands
(
Id int identity primary key,
[Name] nvarchar(20)
)
create table Notebook
(
Id int identity primary key,
[Name] nvarchar(20),
Price float
)
create table Phone
(
Id int identity primary key,
[Name] nvarchar(20),
Price float
)
alter table Notebook
add BrandId int,
Foreign Key(BrandId) references Brands(Id);
select Brands.Id from Brands join Notebook on Brands.Id=Notebook.Id 

alter table Notebook
add BrandName nvarchar (20),
Foreign Key(BrandName) references Brands([Name]);
select Brands.Name from Brands join Notebook on Brands.Name=Notebook.Name 
delete from Brands where Id=9
