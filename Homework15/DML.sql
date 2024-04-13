insert into Customers (FirstName, LastName, Age)
values
    ('John', 'Doe', 32),
    ('Alice', 'Smith', 25),
    ('Bob', 'Johnson', 35),
    ('Emma', 'Davis', 28),
    ('Michael', 'Wilson', 40),
    ('Emily', 'Brown', 33),
    ('James', 'Jones', 27),
    ('Sophia', 'Miller', 31),
    ('William', 'Taylor', 29),
    ('Olivia', 'Anderson', 32);
	
insert into Products (Name, Description, StockQuantity, Price)
values
    ('Laptop', 'High-performance laptop', 50, 1000.00),
    ('Smartphone', 'Latest smartphone model', 100, 800.00),
    ('Tablet', 'Portable tablet device', 80, 500.00),
    ('Headphones', 'Wireless headphones', 120, 150.00),
    ('Camera', 'Digital camera with advanced features', 70, 600.00),
    ('Smartwatch', 'Fitness tracker and smartwatch', 90, 200.00),
    ('Speaker', 'Bluetooth speaker', 110, 100.00),
    ('Monitor', 'Computer monitor with HD display', 60, 300.00),
    ('Keyboard', 'Mechanical gaming keyboard', 85, 80.00),
    ('Mouse', 'Ergonomic wireless mouse', 95, 50.00);
	
insert into Orders (CustomerID, ProductID, Quantity)
values
    (1, 1, 2),
    (2, 3, 1),
    (3, 2, 3),
    (4, 4, 2),
    (5, 1, 1),
    (6, 6, 2),
    (7, 7, 1),
    (8, 1, 3),
    (9, 9, 2),
    (10, 10, 1);