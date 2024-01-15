create database AsanXidmet;
use AsanXidmet;

select * from sys.objects where type in (N'U');

create table Person(
    Id int primary key identity(1,1),
    Name nvarchar(255) not null,
    Surname nvarchar(255) not null
);

create table IdentityCard(
    Id int primary key identity (1,1),
    PersonId int foreign key references Person(Id),
    FIN nvarchar(255) not null,
    Series nvarchar(255) not null,
    IssuingAuthority nvarchar(255) not null,
    Data datetime not null,
    DateOfExpirity datetime not null
);

create table InternationalPassport(
    Id int primary key identity (1,1),
    PersonId int foreign key references Person(Id),
    FIN nvarchar(255) not null,
    Series nvarchar(255) not null,
    IssuingAuthority nvarchar(255) not null,
    Data datetime not null,
    DateOfExpirity datetime not null
);

create table AuthorityManagement(
    Id int primary key identity(1,1),
    Name nvarchar(255) not null
);


create table MovableProperty
(
    Id int primary key identity(1,1),
    PersonId int foreign key references Person(Id),
    VehicleNumber nvarchar(400) not null,
    VehicleManufacturer nvarchar(255) not null,
    VehicleModel nvarchar(300) not null,
    VehicleYear int not null,
    VehicleType nvarchar(255) not null
);

create table RealEstate(
    Id int primary key identity(1,1),
    PersonId int foreign key references Person(Id),
    BillOfSale bit not null,
    TypeOfOwnership nvarchar(255) not null,
    Height float not null,
    Area float not null,
    StreetAddress nvarchar(max) not null,
    PostalCode nvarchar(max) not null
);


create index IdentityCard_PersonId_idx on IdentityCard(PersonId);
create index InternationalPassport_PersonId_idx on InternationalPassport(PersonId);
create index MovableProperty_PersonId_idx on MovableProperty(PersonId);
create index RealEstate_Personid_idx on RealEstate(PersonId);

insert into Person (Name, Surname) values
('John', 'Doe'),
('Alice', 'Smith'),
('Bob', 'Johnson'),
('Elena', 'Petrova'),
('Michael', 'Brown');

insert into IdentityCard (PersonId, FIN, Series, IssuingAuthority, Data, DateOfExpirity) values
(1, '123456789', 'AB123456', 'Local Authority', '2022-01-01', '2025-01-01'),
(2, '987654321', 'CD654321', 'National Office', '2022-02-01', '2026-02-01'),
(3, '555555555', 'XY987654', 'City Hall', '2022-03-01', '2027-03-01');

insert into InternationalPassport (PersonId, FIN, Series, IssuingAuthority, Data, DateOfExpirity) values
(2, '111111111', 'AA111111', 'Foreign Ministry', 2022-02-15, 2026-02-15),
(4, '999999999', 'ZZ999999', 'Consulate Office', 2022-04-01, 2026-04-01);

insert into AuthorityManagement (Name) values
('Ministry of Interior'),
('Foreign Affairs Department'),
('ASAN Service');

insert into MovableProperty (PersonId, VehicleNumber, VehicleManufacturer, VehicleModel, VehicleYear, VehicleType) values
(1, 'ABC123', 'Toyota', 'Camry', 2020, 'Sedan'),
(3, 'XYZ789', 'Honda', 'CR-V', 2019, 'SUV');

insert into RealEstate (PersonId, BillOfSale, TypeOfOwnership, Height, Area, StreetAddress, PostalCode) values
(1, 1, 'Ownership', 3.5, 150.2, '123 Main St', '12345'),
(5, 0, 'Rental', 2.8, 100.5, '456 Oak St', '67890');


insert into Person (Name, Surname) values
('Olga', 'Ivanova'),
('Peter', 'Anderson'),
('Sophia', 'Martinez'),
('Daniel', 'Lee'),
('Eva', 'Garcia');

insert into IdentityCard (PersonId, FIN, Series, IssuingAuthority, Data, DateOfExpirity) values
(5, '777777777', 'EF777777', 'Local Office', '2022-05-01', '2026-05-01'),
(1, '888888888', 'GH888888', 'National Administration', '2022-06-01', '2027-06-01'),
(4, '333333333', 'JK333333', 'City Council', '2022-07-01', '2025-07-01');

insert into InternationalPassport (PersonId, FIN, Series, IssuingAuthority, Data, DateOfExpirity) values
(2, '222222222', 'LM222222', 'Embassy', '2022-08-01', '2027-08-01'),
(3, '444444444', 'OP444444', 'Consulate', '2022-09-01', '2026-09-01');

insert into AuthorityManagement (Name) values
('State Migration Service'),
('Ministry of Foreign Affairs'),
('Regional Police Department');

insert into MovableProperty (PersonId, VehicleNumber, VehicleManufacturer, VehicleModel, VehicleYear, VehicleType) values
(2, 'DEF456', 'Ford', 'Escape', 2018, 'SUV'),
(4, 'HIJ789', 'Chevrolet', 'Malibu', 2021, 'Sedan');

insert into RealEstate (PersonId, BillOfSale, TypeOfOwnership, Height, Area, StreetAddress, PostalCode) values
(3, 1, 'Ownership', 4.2, 200.3, '789 Elm St', '34567'),
(5, 0, 'Rental', 3.0, 120.8, '101 Pine St', '89012');



