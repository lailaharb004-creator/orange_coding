create database FlowersDB;

use FlowersDB ;

/*
1 users table 
2 categories table 
3 products table 
4 cart table 
5 order table 
6 payments table
7 payments methods table 
8 reviews and ratings table
9 wishlist table 
10 cart items table 
11 order items table
12 wishlist items table

-----------------------------------------------------------------------
-----------------------------------------------------------------------
relationships 
user -> order ( one to many ) *****
user -> cart  ( one to one )  *****
user ->reviews and rarings ( one to many )   *****
user -> wishlist ( one to one )  *****

categories ->products ( one to many )  *****

product ->reviews and ratings ( one to many ) *****
product -> order items (one to many )  *****
product -> wishlist items (one to many )   *****
product -> cart items (one to many ) *****



payment -> paymentMethod (many to one )  *****
  

cart ->cart_items  ( one to many ) *****



order ->payment  ( one to one )  *****
order ->order items ( one to many ) *****

wishlist ->wishlist items (one to many) *****

-----------------------------------------------------------------------
-----------------------------------------------------------------------











*/
----------------------------------------------------------------------------------------------------
                           --------------  Users Table  --------------
----------------------------------------------------------------------------------------------------
create table users 
(
	UserId int IDENTITY(1,1)  primary key ,
	UserName varchar(50) ,
	UserEmail varchar(50) not null unique ,
	UserPassword varchar(255) not null  ,
	IsDeleted Bit Default 0,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME NULL
);
----------------------------------------------------------------------------------------------------
                           --------------  Categories Table  --------------
----------------------------------------------------------------------------------------------------
create table categories 
(
	CategoryId  int IDENTITY(1,1)  primary key ,
	CategoryName varchar(255) ,
	IsDeleted Bit Default 0,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME NULL
);
----------------------------------------------------------------------------------------------------
                           --------------  Products Table  --------------
----------------------------------------------------------------------------------------------------

create table products 
(
	ProductId  int IDENTITY(1,1)  primary key ,
	ProductName varchar(255) ,
	ProductPrice decimal(10,2) ,
	ProductColor varchar(50) ,
	ProductSize  varchar(50) ,
	ProductStock int ,
	CategoryId  int ,
	IsDeleted Bit Default 0,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME NULL,

	foreign key (CategoryId) references categories (CategoryId) 
);
----------------------------------------------------------------------------------------------------
                           --------------  Reviews Table  --------------
----------------------------------------------------------------------------------------------------


create table reviewsAndRatings 
(
	ReviewId int  IDENTITY(1,1)  primary key,
	UserId int ,
	ProductId int ,
	ReviewText varchar(800) ,
	Rating int check (Rating between 1 and 5),
	IsDeleted Bit Default 0,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME NULL,
	
	foreign key (UserId) references users (UserId),
	foreign key (ProductId) references products (ProductId),

);
----------------------------------------------------------------------------------------------------
                           --------------  Orders Table  --------------
----------------------------------------------------------------------------------------------------

create table orders 
(
	orderId int IDENTITY(1,1)  primary key ,
	UserId int ,
	OrderDate datetime default getdate(),
	IsDeleted Bit Default 0,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME NULL,

	foreign key (UserId) references users (UserId)
);
----------------------------------------------------------------------------------------------------
                           --------------  PaymentsMethods  Table  --------------
----------------------------------------------------------------------------------------------------

 create table paymentsMethods 
 (
	PaymentMethodId int IDENTITY(1,1)  primary key ,
	PaymentMethodName varchar(50) 	 
 
 );
----------------------------------------------------------------------------------------------------
                           --------------  Payments  Table  --------------
----------------------------------------------------------------------------------------------------
create table payments 
(
	PaymentId int IDENTITY(1,1)  primary key ,
	PaymentStatus varchar(50) ,
	PaymentMethodId int ,
	PaymentDate datetime DEFAULT GETDATE(),
	OrderId int ,
	IsDeleted Bit Default 0,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME NULL,

	foreign key (OrderId) references orders (OrderId) ,
	foreign key (PaymentMethodId) references paymentsMethods (PaymentMethodId) 
 
);
----------------------------------------------------------------------------------------------------
                           --------------  Cart  Table  --------------
----------------------------------------------------------------------------------------------------

create table cart 
(
	CartId int IDENTITY(1,1)  primary key ,
	UserId int unique ,
	IsDeleted Bit Default 0,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME NULL,

	foreign key (UserId) references users (UserId)

);
----------------------------------------------------------------------------------------------------
                           --------------  Wishlist Table  --------------
----------------------------------------------------------------------------------------------------

create table wishlist 
(
	WishlistId int IDENTITY(1,1)  primary key ,
	UserId int unique ,
	IsDeleted Bit Default 0,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME NULL,

	foreign key (UserId) references users (UserId)

);
----------------------------------------------------------------------------------------------------
                           --------------  CartItems Table  --------------
----------------------------------------------------------------------------------------------------

create table cartItems 
(
	CartItemId int IDENTITY(1,1) primary key,
	ProductId int,
	CartId int  ,
	CartItemsQuntity  int ,

	unique (CartId, ProductId),
	foreign key(CartId) references cart (CartId) ,
	foreign key (ProductId) references products (ProductId) 
);
----------------------------------------------------------------------------------------------------
                           --------------  OrderItems Table  --------------
----------------------------------------------------------------------------------------------------
create table orderItems 
(
	OrderItemId int IDENTITY(1,1)  primary key ,
	OrderId int  ,
	ProductId int  ,
	OrderItemQuantity int ,
	OrderItemPrice decimal(10,2) ,

	unique (OrderId, ProductId),
	foreign key (ProductId) references products (ProductId) ,
	foreign key (OrderId) references orders (OrderId) 
);
----------------------------------------------------------------------------------------------------
                           --------------  WishlistItems Table  --------------
----------------------------------------------------------------------------------------------------
create table wishlistItems
(
	WishlistItemId int IDENTITY(1,1) primary key,
	ProductId int ,
	WishlistId int  ,

	unique (WishlistId, ProductId),
	foreign key (ProductId) references products (ProductId) ,
	foreign key (WishlistId) references wishlist (WishlistId)
);







----------------------------------------------------------------------------------------------------
                           --------------  Users Insert Values And Test  --------------
----------------------------------------------------------------------------------------------------
/*
Laila | laila@gmail.com | 123456
Ahmad | ahmad@gmail.com | 123456
Sara  | sara@gmail.com  | 123456
Omar  | omar@gmail.com  | 123456
*/
insert into users (UserName,UserEmail,UserPassword) 
values ('Laila','laila@gmail.com',123456);

insert into users (UserName,UserEmail,UserPassword) 
values ('Ahmad','ahmad@gmail.com',123456);

insert into users (UserName,UserEmail,UserPassword) 
values ('Sara','sara@gmail.com',123456);

insert into users (UserName,UserEmail,UserPassword) 
values ('Omar','omar@gmail.com',123456);


select * from users ;
update users set IsDeleted=1 where UserId=4;

----------------------------------------------------------------------------------------------------
                           --------------  Categories Insert Values And Test  --------------
----------------------------------------------------------------------------------------------------
/*
Tulips
Bouquets
Indoor Plants
Gifts
*/
insert into  categories (CategoryName) 
values ('Tulips');

insert into categories (CategoryName) 
values ('Bouquets');

insert into categories (CategoryName) 
values ('Indoor Plants');

insert into categories (CategoryName) 
values ('Gifts');

select * from categories ;
----------------------------------------------------------------------------------------------------
                           --------------  Products Insert Values And Test  --------------
----------------------------------------------------------------------------------------------------
/*
1 | Red Rose          | 5.00  | Red    | Small  | 100 | 1
2 | White Rose        | 6.00  | White  | Small  | 80  | 1
3 | Pink Tulip        | 4.50  | Pink   | Medium | 60  | 1
4 | Sunflower Bouquet | 25.00 | Yellow | Large  | 40  | 2
5 | Luxury Bouquet    | 50.00 | Mixed  | Large  | 20  | 2
6 | Snake Plant       | 25.00 | Green  | Medium | 30  | 3
7 | Orchid Flower     | 35.00 | Purple | Medium | 25  | 4

    ProductName 
	ProductPrice 
	ProductColor 
	ProductSize  
	ProductStock 
	CategoryId  
*/


insert into products ( ProductName,ProductPrice,ProductColor,ProductSize,ProductStock,CategoryId) 
values ('Red Rose',5,'Red','Small',100,1);

insert into products ( ProductName,ProductPrice,ProductColor,ProductSize,ProductStock,CategoryId) 
values ('White Rose',6,'White','Small',80,1);

insert into products ( ProductName,ProductPrice,ProductColor,ProductSize,ProductStock,CategoryId) 
values ('Pink Tulip',4.50,'Pink','Medium',60,1);

insert into products ( ProductName,ProductPrice,ProductColor,ProductSize,ProductStock,CategoryId) 
values ('Sunflower Bouquet',25,'Yellow','Large',40,2);

insert into products ( ProductName,ProductPrice,ProductColor,ProductSize,ProductStock,CategoryId) 
values ('Luxury Bouquet',50,'Mixed','Large',20,2);

insert into products ( ProductName,ProductPrice,ProductColor,ProductSize,ProductStock,CategoryId) 
values ('Snake Plant',25,'Green','Medium',30,3);

insert into products ( ProductName,ProductPrice,ProductColor,ProductSize,ProductStock,CategoryId) 
values ('Orchid Flower',35,'Purple','Medium',25,4);

select * from products;
----------------------------------------------------------------------------------------------------
                           --------------  Payments Methods Insert Values And Test  --------------
----------------------------------------------------------------------------------------------------
/*
1 | Cash
2 | Credit Card
3 | PayPal
*/
insert into paymentsMethods (PaymentMethodName) 
values ('Cash');

insert into paymentsMethods (PaymentMethodName) 
values ('Credit Card');

insert into paymentsMethods (PaymentMethodName) 
values ('PayPal');

select * from paymentsMethods;
----------------------------------------------------------------------------------------------------
                           --------------  Cart  Insert Values And Test  --------------
----------------------------------------------------------------------------------------------------
/* 
1 | 1
2 | 2
3 | 3
4 | 4
*/
insert into cart (UserId) 
values (1) ;

insert into cart(UserId) 
values (2) ;

insert into cart (UserId) 
values (3) ;

insert into cart (UserId) 
values (4) ;

select * from cart ;
----------------------------------------------------------------------------------------------------
                           --------------  Wishlist  Insert Values And Test  --------------
----------------------------------------------------------------------------------------------------
/* 
1 | 1
2 | 2
3 | 3
4 | 4
*/
insert into wishlist (UserId) 
values (1) ;

insert into wishlist(UserId) 
values (2) ;

insert into wishlist(UserId) 
values (3) ;

insert into wishlist(UserId) 
values (4) ;

select * from wishlist;
----------------------------------------------------------------------------------------------------
                           --------------  Orders  Insert Values And Test  --------------
----------------------------------------------------------------------------------------------------
/* 
1 | 1
2 | 2
3 | 3
4 | 4
*/
insert into orders (UserId) 
values (1) ;

insert into orders (UserId) 
values (2) ;

insert into orders (UserId) 
values (3) ;

insert into orders (UserId) 
values (4) ;
select * from orders;
----------------------------------------------------------------------------------------------------
                           --------------  Cart items  Insert Values And Test  --------------
----------------------------------------------------------------------------------------------------
/*
1 | 1 | 1 | 2
2 | 2 | 2 | 1
3 | 4 | 3 | 1
4 | 6 | 4 | 1
    ProductId 
	CartId  
	CartItemsQuntity  

*/
insert into cartItems (ProductId,CartId ,CartItemsQuntity) 
values (1,1,2);

insert into cartItems (ProductId,CartId ,CartItemsQuntity) 
values (2,2,1);

insert into cartItems (ProductId,CartId ,CartItemsQuntity) 
values (4,3,1);

insert into cartItems (ProductId,CartId ,CartItemsQuntity) 
values (6,4,1);

select * from cartItems;
----------------------------------------------------------------------------------------------------
                           --------------  orderitems  Insert Values And Test  --------------
----------------------------------------------------------------------------------------------------
/*
1 | 1 | 1 | 3 | 15.00
2 | 2 | 2 | 2 | 12.00
3 | 3 | 5 | 1 | 50.00
4 | 4 | 3 | 5 | 22.50
    OrderId
	ProductId 
	OrderItemQuantity 
	OrderItemPrice
*/
insert into orderItems (OrderId,ProductId ,OrderItemQuantity,OrderItemPrice) 
values (1,1,3,15) ;

insert into orderItems (OrderId,ProductId ,OrderItemQuantity,OrderItemPrice) 
values (2,2,2,12) ;

insert into orderItems (OrderId,ProductId ,OrderItemQuantity,OrderItemPrice) 
values (3,5,1,50) ;

insert into orderItems (OrderId,ProductId ,OrderItemQuantity,OrderItemPrice) 
values (4,3,5,22.50) ;

select * from orderItems;

----------------------------------------------------------------------------------------------------
                           --------------  Payments  Insert Values And Test  --------------
----------------------------------------------------------------------------------------------------
/* 
1 | Completed | 1 | 2026-04-10 | 1
2 | Pending   | 2 | 2026-04-10 | 2
3 | Completed | 3 | 2026-04-10 | 3
4 | Failed    | 1 | 2026-04-10 | 4

    PaymentStatus 
	PaymentMethodId 
	PaymentDate 
	OrderId 

*/
insert into payments (PaymentStatus,PaymentMethodId,PaymentDate,OrderId) 
values ('Completed',1,'2026-04-10',1) ;

insert into payments (PaymentStatus,PaymentMethodId,PaymentDate,OrderId) 
values ('Pending',2,'2026-04-10',2) ;

insert into payments (PaymentStatus,PaymentMethodId,PaymentDate,OrderId) 
values ('Completed',3,'2026-04-10',3) ;

insert into payments (PaymentStatus,PaymentMethodId,PaymentDate,OrderId) 
values ('Failed',1,'2026-04-10',4) ;

select * from payments;
----------------------------------------------------------------------------------------------------
                    --------------  Reviews and Ratings  Insert Values And Test  --------------
----------------------------------------------------------------------------------------------------
/*
1 | 1 | 1 | Amazing flower!         | 5
2 | 2 | 2 | Very clean and fresh    | 4
3 | 3 | 4 | Nice bouquet            | 5
4 | 4 | 6 | Small but good quality  | 3

    UserId 
	ProductId
	ReviewText 
	Rating 

*/
insert into reviewsAndRatings (UserId,ProductId,ReviewText,Rating)
values (1,1,'Amazing flower!',5) ;

insert into reviewsAndRatings (UserId,ProductId,ReviewText,Rating)
values (2,2,'Very clean and fresh',4) ;

insert into reviewsAndRatings (UserId,ProductId,ReviewText,Rating)
values (3,4,'Nice bouquet',5) ;

insert into reviewsAndRatings (UserId,ProductId,ReviewText,Rating)
values (4,6,'Small but good quality',3) ;

select * from reviewsAndRatings;

----------------------------------------------------------------------------------------------------
                    --------------  wishlist items  Insert Values And Test  --------------
----------------------------------------------------------------------------------------------------
/*  
1 | 1 | 5
2 | 2 | 3
3 | 3 | 6
4 | 4 | 1

    ProductId 
	WishlistId 

*/
insert into wishlistItems(ProductId,WishlistId) 
values (5,1) ;

insert into wishlistItems(ProductId,WishlistId) 
values (3,2) ;

insert into wishlistItems(ProductId,WishlistId) 
values (6,3) ;

insert into wishlistItems(ProductId,WishlistId) 
values (1,4) ;

select * from wishlistItems;

----------------------------------------------------------------------------------------------------
                    --------------   SELECT Queries Scenarios  --------------
----------------------------------------------------------------------------------------------------
--Get all orders with user information--
select  users.UserName,users.UserId,users.UserEmail,orders.orderId from users   join orders on users.UserId=orders.UserId;

--Show available products (not deleted) sorted by price
select ProductId,ProductName,ProductPrice from products where products.IsDeleted=0;

--Get products with their average rating
select products.ProductId,ProductName,ProductPrice ,avg(rating) from products join reviewsAndRatings on reviewsAndRatings.ProductId=products.ProductId group by products.ProductId,ProductName,ProductPrice;

--Get all products in a specific user’s wishlist
select * from wishlistItems where wishlistItems.WishlistId= (select WishlistId from wishlist where UserId=1);

--Get total sales per user
select sum(OrderItemPrice* OrderItemQuantity)as 'Total Sales',UserId from orderItems join orders  on orderItems.OrderId=orders.orderId  group by UserId;

--Get products within a price range
select products.ProductId ,products.ProductName ,products.ProductSize ,ProductPrice from products where ProductPrice between 30 and 50 ;

---Get last 5 orders
select top 5 * from orders order by OrderDate desc ;

--Get all users, even those who have no orders

insert into users (UserName,UserEmail,UserPassword) 
values ('Ali','ali@gmail.com',123456);

select * from users;

select users.UserName,users.UserId,users.UserEmail,orders.orderId from users   left join orders on users.UserId=orders.UserId;

--Count total orders per user
select  UserId , count (OrderId) as 'Total Orders'   from orders group by UserId;