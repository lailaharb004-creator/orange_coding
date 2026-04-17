create database  StoreDB ;
USE StoreDB;

CREATE TABLE Users (
    Id INT PRIMARY KEY,
    Name VARCHAR(50),
    Email VARCHAR(100),
    Age INT
);

CREATE TABLE Orders (
    Id INT PRIMARY KEY,
    UserId INT,
    ProductName VARCHAR(100),
    Price DECIMAL(10,2)
);
/* 1 */
insert into Users 
values (1 ,'Ahmad','ahmad@gmail.com',25);

insert into Users 
values (2,'Ali','ali@gmail.com',30);

insert into Users 
values (3 ,'Sara','sara@gmail.com',22);

/* 2 */
insert into Orders 
values (1,1,'Laptop',800);

insert into Orders 
values (2,2,'Phone',500) ;

insert into Orders 
values (3,1,'Mouse',20);

insert into Orders 
values (4,3,'Keyboard',50);

/* 3 */
insert into Users (Id,Name,Age)
values (4,'Omar','Age') ;

/* 4 */
update Users set Email='sara_new@gmail.com' where Name='Sara';
/* 5 */
update Orders set Price=Price+10 ;
/* 6 */
update Users set Id=2 where Name In('Ali','Ahmad');
/* 7 */
delete from Users where id=4;
/* 8 */
delete  from Orders where Price<=50;
/* 9 */
delete from Orders where UserId=3;
/* 10 */
select * from Users ;
/* 11 */
select Name ,Email from Users; 
/* 12 */
select * from Users where Age >25 ;
/* 13 */
select * from Users where Name like('A%');
/* 14 */
select * from Users where Email is null ;
/* 15 */
select * from Orders where Price between 50 and 800; 
/* 16 */
select * from Orders where ProductName like ('%Phone%');
/* 17 */
select * from Orders order by Price ;
/* 18 */
select * from Users where Age<30 order by Name ;
/* 19 */
select * from Orders where Price >100 And UserId =1 ;
/* 20 */
select * from Users where Age between 20 And 30 and Name like ('%a%') ;




