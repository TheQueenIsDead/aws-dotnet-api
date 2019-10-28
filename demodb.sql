create database TestDb;
use TestDb;
create table Products (
	ProductId int not null,
    ProductName nvarchar(50) not null,
    ProductStock int default 0
);
insert into Products values (1, 'DemoProduct', 12)