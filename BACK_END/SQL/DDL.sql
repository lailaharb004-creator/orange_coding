/* 
tables                 users     products  orders  OrderProduct categories employees customers  payments students  courses
					   logs 
relationships
---------------------------     
each order must be realted to user id          ( users && orders )
table from concat orders and products ?? in one order the product should not appear twice in the same order  (products && orders)
each  product belong to one category but multiple products may belong to the same category (one to many )    (produts &&categories) 
each payment must be linked to an order (payments && orders) 
each product belongs to one category (products && categories) 
employee can have a manager from the same table ( employee && manager) 
Students can take multiple courses (students && courses) 

---------------------------

*/



/* 1 */
create database OnlineStore ;
use OnlineStore ;
/* 2 */
create table users
(
	UserId int  primary key , 
	UserName  varchar(50)
);
/* 3 */
alter table users 
	add email varchar(50) unique ;
/* 4 */
alter table users 
	alter column email varchar(50)  not null ;
/* 5 */
create table products 
(
	ProductName varchar(50)  primary key,
	ProductPrice decimal (10,2)
);
/* 6 */
alter table products 
	alter column ProductPrice decimal(10,2) not null;
/* 7 */
create table orders 
(
	
	OrderId  int primary key ,
	U_ID int ,
	foreign key  (U_ID) references users(UserId)

);
/* 8 */
alter table orders 
	add  OrderDate datetime ;
/* 9 */
alter table orders 
	add constraint DefaultOrderDate default (getdate()) for OrderDate ;
/*
another solution for question 9 
alter table orders 
	add constraint DefaultOrderDate default (getutcdate()) for OrderDate ;
*/ 

/* 10 */
create table  OrderProduct 
(
	O_ID int , 
	P_Name varchar(50) ,
	foreign key (O_ID) references orders(OrderId) ,
	foreign key (P_Name) references products(ProductName) ,

);
/* 11 */
create table categories 
(
	categoryName varchar (50) ,
	P_Name 
	foreign key (P_Name) references products (ProductName) 
	
);
/* 12 */
create table employeees 
(
	employeeId int primary key ,
	managerId int ,
	foreign key (managerId) references employees (employeeId) 
);
/* 13-1*/
alter table users 
	add column phone int ;
/* 13-2 */
alter table users 
	drop column phone ;
/* 14 */
alter table users 
	alter column name varchar(100)  ;
/* 15 */
create table customers 
(
	CustomerName varchar(50) not null ,
	customerPhone int 
);
/* 16 */
create table  payments 
(
	paymentId decimal(10,1) ,
	O_ID int , 
	foreign key (O_ID) references orders (OrderId)

); 
/* 17 */
create table students 
(
	StudentId int primary key ,
	StudentName varchar(50) 

); 
/* 18 */
create table courses 
(
	CourseTitle varchar(50) ,
);
/* 19 */

/* 20 */
create table logs 
(
	LogMessages varchar(50) ,
	LogTimeStamps int
);
/* 21 */
truncate table logs ;
/* 22 */
alter table courses 
	drop column CourseTitle ;
/* 23 */
drop table courses ;
/* 24 */
 create table AutoId 
 (
	id  int identity(1,1) 
 );
 /* 25 */
 create table TwoColumns 
 (
	one int not null ,
	two int
 );
 /* 26 */
 create table books 
 (
	 BooksTitle varchar(50)  primary key ,
	 BooksPrice decimal (10,
 );
  /* 27 */
  create table authors 
  (
	bookT  varchar(50) ,
	authorName varchar(50) ,
	foreign key (bookT) references books(BooksTitle) 
  );
  
  /* 28 */
  create table OnlyIds 
  (
		id int 
  );

  /* 29 */
  create table ThreeColumns 
  (
	one int , 
	two varchar(50),
	three datetime
  
  );

   /* 30-1 */
   create table UniqueColumn 
   (
      one int ,
	  two int 
   );
    /* 30-2 */
	alter table UniqueColumn 
		add constraint one unique ;
	/* 31 */
	create database testing ;
	/* 32 */
	drop database testing;
	/* 33 */
	alter table products 
		add column ProductsDescription varchar(50)  ;
	/* 34 */
	drop table products ;
	/* 35 */
	create table OneColumn (one int);

	/* 36 */
	create table #temporaryTable 
	(
		one int 
	);
	/* 37-1 */
	create table DeleteContent 
	(
		one int 
	);
	/* 37-2 */
	truncate table DeleteContent ;

	/* 38 */
	create table EmailTable 
	(
		email varchar(50) unique not null 
	);
	/* 39 */
	create table PriceExist 
	(
		price decimal (10,1) not null
	
	);
	/* 40 */
	create table FieldsTable 
	(
		id int unique ,
		field varchar(50) not null unique 
	);









 












