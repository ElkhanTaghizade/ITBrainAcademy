create database Hotel
use Hotel
create table  RoomTypes (
	Id int primary key identity,
	[Name] varchar(50) not null unique,
	Price float
)
create table Rooms (
	Id int primary key identity,
	RoomTypesId int not null unique
	Foreign Key(RoomTypesId) references RoomTypes(Id)
)
create table Customer(
   Id int primary key identity,
   [Name] nvarchar(50)
)
create table Reservations (
    Id int primary key identity,
    CustomerId int not null,
    Foreign Key (CustomerId) references Customer(Id),
    RoomId int not null,
    CheckInDate DateTime,
    CheckOutDate DateTime,
    Foreign Key (RoomId) references Rooms(Id)
);
create table Payments(
Id int primary key identity,
ReservId int unique,
Foreign Key(ReservId) references Reservations(Id),
Amount float
)
create view AllCustomerReservations As
select
    Customer.Name As CustomerName,
    Reservations.CheckInDate As InDate,
    Reservations.CheckOutDate As OutDate 
from Customer 
inner join Reservations on Customer.Id = Reservations.CustomerId;

select * from AllCustomerReservations

create Procedure usp_GetRoomDetails @roomID int
As
 select  Rooms.Id, RoomTypes.Name, RoomTypes.Price from Rooms inner join RoomTypes on Rooms.RoomTypesId=RoomTypes.Id where @roomID=Rooms.Id

exec usp_GetRoomDetails 2

create function dbo.CalculateTotalAmount (@CusId int)
returns float
As
begin
declare @Amount float;
select @Amount=Payments.Amount from Payments inner join Reservations on Reservations.Id=Payments.ReservId where @CusId=Reservations.CustomerId
return @Amount
end

select * from dbo.CalculateTotalAmount('2')
alter table Rooms
add IsBooked nvarchar default('false')

create trigger UpdateRoomStatusOnReservation
on database  after Insert 
As
    update Rooms
    set IsBooked = 'true'
    where Id in (select Id from Rooms);
RollBack;