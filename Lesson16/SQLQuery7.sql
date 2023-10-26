create database Base2
use Base2
create table Customer
(
Id int primary key identity,
[Name] nvarchar(20),
Surname nvarchar(20),
)
create table Orders
(
Id int primary key identity,
[Name] nvarchar(20),
Price float
)
insert into Customer(Name,Surname)
values ('Elkhan', 'Taghizade'),
('Ilkin', 'Novruzov'),
('Nasir', 'Asadov')
insert into Orders (Name,Price)
values ('Asus', 2300),
('Macbook',3000),
('Lenevo', 2100)

delete from Customer where id>3

use Base

CREATE TABLE CusOrd
(
    CusId INT not null,
    OrdId INT not null,
    FOREIGN KEY (CusId) REFERENCES Customer(Id),
    FOREIGN KEY (OrdId) REFERENCES Orders(Id),
    PRIMARY KEY(CusId,OrdId)
);
select * from CusOrd c join Orders o on c.CusId=O.Id

CREATE TABLE Employees (
    EmployeeID int primary key identity,
    EmployeeName nvarchar(20),
    JobTittle nvarchar(20),
    ManagerName nvarchar (20)
);
INSERT INTO Employees (EmployeeName, JobTittle, ManagerName)
VALUES
    ('Employee1', 'Job1', 'Manager1'),
    ('Employee2', 'Job2', 'Manager2'),
    ('Employee3', 'Job3', 'Manager3'),
    ('Employee4', 'Job4', 'Manager4'),
    ('Employee5', 'Job5', 'Manager5')

SELECT
    E.EmployeeName AS EmpName,
    E.JobTittle AS JobTitle,
    E.ManagerName AS ManName
FROM
    Employees E
create table Country
(
Id int primary key identity,
[Name] nvarchar (25)
)
create table City
(
Id int primary key identity,
[Name] nvarchar (25)
)
insert into Country([Name])

values ('USA'), ('Azerbaijan'), ('Turkiye'), ('Georgia')

insert into City([Name])
values ('Washington'), ('Baku'), ('Ankara'), ('Tiflis')


alter table City
add CountryId int  
Foreign Key(CountryId) references Country(Id)
select c1.Name, c2.Name from Country c1 join City c2 on c1.Id=c2.Id

insert into Country(Name)
 values ('Irish')
select c1.Name, c2.Name from Country c1 left join City c2 on c1.Id=c2.Id

 insert  into City (Name)
 values ('Tehran'),
 ('Astana')
select c1.Name, c2.Name from Country c1 right join City c2 on c1.Id=c2.Id




