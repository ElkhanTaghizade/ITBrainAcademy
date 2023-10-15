create database Company
use Company
create table Customers
(
ID int primary key,
[NAME] nvarchar(15),
SURNAME nvarchar(20),
SALARY float
)
insert into Customers(ID,NAME,SURNAME,SALARY)
values(0001,'Elkhan', 'Taghizade', 800),
(0002,'lkin', 'Novruzov', 900),
(0003,'Nesir', 'Asadov', 1000)

select * from Customers

update Customers
set NAME='Elkhan1' where NAME='Elkhan'

delete Customers
where  NAME='Nesir'

insert into Customers(ID,NAME,SURNAME,SALARY)
values(0003,'Nesir', 'Asadov', 1000)

select AVG (SALARY) from Customers
select * from Customers where SALARY>(select AVG (SALARY) from Customers) 
select Min (SALARY) from Customers
select Max (SALARY) from Customers
select top 1 NAME from Customers order by SALARY desc
select top 1 SURNAME from Customers order by SALARY asc
