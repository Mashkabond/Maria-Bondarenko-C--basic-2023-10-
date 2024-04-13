create table Customers
(
	ID bigserial not null,
	FirstName varchar(64) not null,
	LastName varchar(64) not null,
	Age int not null,
	
	constraint pk_Customers primary key (ID)
);
create index idx_Customers_Age on Customers (Age);

create table Products
(
	ID bigserial not null,
	Name varchar(64) not null,
	Description text,
	StockQuantity int not null,
	Price money not null,
	
	constraint pk_Products primary key (ID)
);
create index idx_Products_StockQuantity on Products (StockQuantity);

create table Orders
(
	ID bigserial not null,
	CustomerID bigserial not null,
	ProductID bigserial not null,
	Quantity int not null,
	
	constraint pk_Orders primary key (ID),
	constraint fk_Orders_Customers foreign key (CustomerID) references Customers (ID),
	constraint fk_Orders_Products foreign key (ProductID) references Products (ID)
);
create index idx_Orders_CustomerID on Orders (CustomerID) include (ProductID, Quantity);
create index idx_Orders_ProductID on Orders (ProductID) include (CustomerID, Quantity);
