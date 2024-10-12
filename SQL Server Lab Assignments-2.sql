--SQL Server Lab Assignments - 2

--SQL Server Assignments on Aggregate Queries (SUM, MIN, MAX, AVG)
--Assignment 1: Sales Database
--You are given a Sales table containing sales data for various products.
CREATE TABLE Sales (
	SaleID int primary key identity(1,1),
	ProductID int,
	ProductName varchar(50),
	QuantitySold int,
	SaleAmount int,
	SaleDate date
);

INSERT INTO Sales VALUES
(101, 'Laptop', 5, 5000, '2024-09-01'),
(102, 'Mouse', 10, 250, '2024-09-02'),
(101, 'Laptop', 3, 3000, '2024-09-03'),
(103, 'Keyboard', 8, 800, '2024-09-04'),
(102, 'Mouse', 6, 150, '2024-09-05');

SELECT *FROM Sales;

--1: Write a query to calculate the total sales amount for all products (SUM).
select sum(SaleAmount) as TotalSalesAmount from Sales;

--2: Write a query to find the maximum quantity sold of any product (MAX).
select max(QuantitySold) as MaximumQuantitySold from Sales;

--3: Write a query to calculate the average sale amount per sale (AVG).
select avg(SaleAmount) as AverageSalesAmount from Sales;

--4: Write a query to find the minimum sale amount in the database (MIN).
select min(SaleAmount) as MinimumSalesAmount from Sales;

--5: Write a query to calculate the total quantity sold of a specific product, say "Laptop" (SUM with WHERE clause).
select sum(QuantitySold) as TotalQuantitySold from Sales where ProductName = 'Laptop';


--Assignment 2: Employee Salaries
--You are given an Employees table with salary details.
create table Employees(
	EmployeeID int primary key identity(1,1) NOT NULL,
	EmployeeName varchar(50),
	Department varchar(50),
	Salary int,
	HireDate date
);

insert into Employees
values('John Doe', 'IT', 5000, '2022-01-10'),
('Jane Smith', 'HR', 6000, '2021-03-15'),
('Bob Johnson', 'Finance', 5500, '2020-06-20'),
('Alice Brown', 'IT', 6200, '2023-02-01'),
('Charlie White', 'Marketing', 4800, '2023-03-10');

select *from Employees;

--1: Write a query to find the total salary expenditure for all employees (SUM).
select sum(Salary) as TotalSalaryExpenditure from Employees;

--2: Write a query to find the highest salary among all employees (MAX).
select max(Salary) as HighestSalary from Employees;

--3: Write a query to calculate the average salary across all employees (AVG).
select avg(Salary) as AverageSalary from Employees;

--4: Write a query to find the minimum salary in the IT department (MIN with WHERE clause).
select min(Salary) as MinimumSalary from Employees where Department = 'IT';

--5: Write a query to find the total number of employees in each department (COUNT and GROUP BY).
select Department, count(*) as NumberOfEmployees from Employees group by Department;


--Assignment 3: Inventory Management
--You are given an Inventory table with information about the stock levels of different products.
CREATE TABLE Inventory (
	ProductID int primary key identity(201,1),
	ProductName varchar(50),
	QuantityInStock int,
	ReorderLevel int,
	LastRestockDate date
);

INSERT INTO Inventory VALUES
('Monitor', 50, 10, '2024-08-25'),
('Printer', 30, 5, '2024-09-01'),
('Mouse', 100, 15, '2024-09-10'),
('Keyboard', 80, 20, '2024-09-15'),
('Laptop', 25, 5, '2024-09-20');

select *from Inventory;

--1: Write a query to find the total quantity of products in stock (SUM).
select sum(QuantityInStock) as TotalQuantityOfProducts from Inventory;

--2: Write a query to find the product with the highest quantity in stock (MAX).
select ProductName, QuantityInStock from Inventory where QuantityInStock = (select max(QuantityInStock) from Inventory);

--3: Write a query to find the average reorder level across all products (AVG).
select avg(ReorderLevel) as AverageReorderLevel from Inventory;

--4: Write a query to find the product with the lowest reorder level (MIN).
select ProductName, ReorderLevel from Inventory where ReorderLevel = (select min(ReorderLevel) from Inventory);

--5: Write a query to find the total quantity in stock for products where the quantity is
--less than the reorder level (SUM with WHERE clause).
select sum(QuantityInStock) as TotalQuantityInStock from Inventory where QuantityInStock < ReorderLevel;


--Assignment 4: Customer Orders Database
--You have a CustomerOrders table that contains details about customer orders. 
create table CustomerOrders(
	OrderID int primary key identity(501,1),
	CustomerID varchar(10),
	OrderDate date,
	OrderAmount int,
	QuantityOrdered int
);

insert into CustomerOrders values
('C001', '2024-09-10', 1500, 3),
('C002', '2024-09-11', 2000, 5),
('C001', '2024-09-12', 1000, 2),
('C003', '2024-09-13', 2500, 4),
('C002', '2024-09-14', 3000, 6);

select *from CustomerOrders;

--1. Write a query to calculate the total order amount for all orders (SUM).
select sum(OrderAmount) as TotalOrderAmount from CustomerOrders;

--2. Write a query to find the average order amount for all customers (AVG).
select avg(OrderAmount) as AverageOrderAmount from CustomerOrders;

--3. Write a query to find the maximum order amount from a single order (MAX).
select max(OrderAmount) as MaximumOrderAmount from CustomerOrders;

--4. Write a query to find the total quantity ordered across all orders (SUM).
select sum(QuantityOrdered) as TotalQuantityOrdered from CustomerOrders;

--5. Write a query to find the minimum order amount in the database (MIN).
select min(OrderAmount) as MinimumOrderAmount from CustomerOrders;


--Assignment 6: Product Ratings Database
--You have a ProductRatings table containing customer ratings for various products.
create table ProductRatings(
	RatingID int primary key identity(1,1),
	ProductID varchar(10),
	CustomerID varchar(10),
	Rating int,
	ReviewDate date,
);

insert into ProductRatings values
('P001', 'C001', 4, '2024-09-01'),
('P002', 'C002', 5, '2024-09-02'),
('P001', 'C003', 3, '2024-09-03'),
('P003', 'C001', 2, '2024-09-04'),
('P002', 'C004', 4, '2024-09-05');

select *from ProductRatings;

--1. Write a query to calculate the average rating for each product (AVG with GROUP BY).
select ProductID, avg(Rating) as AverageRating from ProductRatings group by ProductID;

--2. Write a query to find the highest rating given to any product (MAX).
select max(Rating) as HighestRating from ProductRatings;

--3. Write a query to find the lowest rating given to any product (MIN).
select min(Rating) as LowestRating from ProductRatings;

--4. Write a query to find the total number of ratings for each product (COUNT and GROUPBY).
select ProductID, Count(*) as TotalNumberOfRatings from ProductRatings group by ProductID;

--5. Write a query to find the total number of products rated (COUNT with DISTINCT).
select count(distinct ProductID) as TotalNumberOfProductsRated from ProductRatings;


--SQL Server assignments and solutions using various SQL operators such as IN, BETWEEN, LIKE, AND, OR, NOT, etc.
--Assignment 1: Retrieve Employees Who Work in Specific Departments Using IN Operator
create table Employees(
	EmployeeID int primary key identity(101,1),
	EmployeeName varchar(50),
	Department varchar(50)
);

insert into Employees values
('John Doe', 'IT'),
('Jane Smith', 'HR'),
('Bob Johnson', 'Finance'),
('Alice Brown', 'IT'),
('Charlie White', 'Marketing');

select *from Employees;

--Retrieve the names of employees who work in either the 'HR', 'Finance', or 'IT' departments.
select EmployeeName from Employees where  Department = 'HR' or Department = 'Finance' or Department = 'IT';


--Assignment 2: Retrieve Products Within a Specific Price Range Using BETWEEN Operator
--Retrieve the product names and prices of products that are priced between 100 and 500.
create table Products(
	ProductID int primary key identity(1,1),
	ProductName varchar(50),
	Price int,
);

insert into Products values ('Laptop', 1000),
('Mouse',  20),
('Keyboard', 30),
('Printer', 150);

select *from Products;
select ProductName, Price from Products where Price between 100 and 500;

--Assignment 3: Find Customers Whose Name Starts With 'A' Using LIKE Operator
--Task: Retrieve the customer names that start with the letter 'A'.
select *from Customers;
select CustomerName from Customers where CustomerName  like 'A%';

--Assignment 4: Retrieve Orders Placed on Specific Dates Using IN Operator
--Task: Retrieve the order IDs of orders placed on '2023-01-01', '2023-02-01', and '2023-03-01'.
select *from Orders;
select OrderID from Orders where OrderDate in ('2024-01-01', '2023-02-01', '2023-03-01');

--Assignment 5: Retrieve Products That Are Not Priced Between 100 and 500 Using NOT BETWEEN Operator
--Task: Retrieve the product names and prices of products that are not priced between 100 and 500.
select *from Products;
select ProductName, Price from Products where Price not between 100 and 500;

--Assignment 6: Find Orders Where the Total Amount is More Than 5000 or Less Than 1000 Using OR Operator
--Task: Retrieve the order IDs where the total amount is either greater than 5000 or less than 1000.
select *from Orders;
select OrderID from Orders where TotalAmount > 5000 or TotalAmount < 1000;

--Assignment 7: Retrieve Employees Who Do Not Work in the 'HR' or 'IT' Departments Using NOT IN Operator
--Task: Retrieve the names of employees who do not work in the 'HR' or 'IT' departments.
select *from Employees;
select EmployeeFullName from Employees where Department not in ('HR','IT');

--Assignment 8: Retrieve Orders Placed in 2023 Using BETWEEN and AND Operators
--Task: Retrieve the order IDs of orders placed between '2023-01-01' and '2023-12-31'.
select *from Orders;
select OrderID from Orders where OrderDate between '2023-01-01' and '2023-12-31';

--Assignment 9: Find Customers Who Do Not Have 'John' in Their Name Using NOT LIKE Operator
--Task: Retrieve the customer names that do not have 'John' in them.
select *from Customers;
select CustomerName from Customers where CustomerName not like '%John%';

--Assignment 10: Retrieve Products That Are Either in Category 'A' or Priced Below 100 Using IN and OR Operators
--Task: Retrieve the product names and prices of products that are either in category 'A' or have a price less than 100.
--create table Categories(CategoryID int primary key identity, CategoryName varchar(5));
--alter table Products add CategoryID int;
select *from Products;
select *from Categories;
select ProductName, Price from Products where CategoryID = (select CategoryID from Categories where CategoryName = 'A') or Price >100;


--SQL Server assignments focused on using the ALTER TABLE command to perform various table modifications.
--Assignment 1: Add a New Column
--Task: Add a column DateOfBirth (data type DATE) to the Employees table to store employees' dates of birth.
alter table Employees add DateOfBirth date;

--Assignment 2: Modify Column Data Type
--Task: Change the data type of the PhoneNumber column in the Customers table to VARCHAR(15).
alter table Customers alter column PhoneNumber varchar(15);

--Assignment 3: Add a Primary Key
--Task: Add a primary key to the DepartmentID column in the Departments table.
alter table Departments add constraint PK_Department primary key(DepartmentID);

--Assignment 4: Drop a Column
--Task: Remove the MiddleName column from the Employees table.
--alter table Employees add MiddleName varchar(50);
alter table Employees drop column MiddleName;

--Assignment 5: Add a Foreign Key
--Task: Add a foreign key to the EmployeeID column in the Orders table that references the EmployeeID column in the Employees table.
--alter table Orders add EmployeeID int; 
alter table Orders add constraint FK_Orders_Employees foreign key(EmployeeID) references Employees(EmployeeID);

--Assignment 6: Drop a Foreign Key
--Task: Remove the foreign key constraint that references EmployeeID from the Orders table.
alter table Orders drop constraint FK_Orders_Employees;

--Assignment 7: Rename a Column
--Task: Rename the column EmployeeName to EmployeeFullName in the Employees table.
Exec sp_rename 'Employees.EmployeeName', 'EmployeeFullName', 'COLUMN';

--Assignment 8: Add a Default Value
--Task: Add a default value of 'Active' to the Status column in the Employees table.
--alter table Employees add Status varchar(50);
alter table Employees add constraint DF_Status default 'Active' for Status; 

--Assignment 9: Drop a Primary Key
--Task: Drop the primary key constraint from the Departments table.
alter table Departments drop constraint PK_Department;

--Assignment 10: Add a Unique Constraint
--Task: Ensure the Email column in the Employees table is unique by adding a unique constraint.
--alter table Employees add Email varchar(50);
alter table Employees add constraint UQ_Email unique(Email);

--Assignment 11: Add a Check Constraint
--Task: Add a check constraint to the Salary column in the Employees table to ensure that no salary is less than 1000.
--alter table Employees add Salary int;
alter table Employees add constraint CK_Salary check(Salary > 1000);

--Assignment 13: Drop a Check Constraint
--Task: Remove the check constraint from the Salary column in the Employees table.
alter table Employees drop constraint CK_Salary;


--SQL Server assignments involving subqueries.

--Assignment 1: Retrieve Employees Who Earn More Than the Average Salary
--Task: Retrieve the names and salaries of employees whose salary is greater than the average salary of all employees in the company.
select *from Employees;
select EmployeeFullName, Salary from Employees where Salary > (select avg(Salary) from Employees);

--Assignment 2: Find Departments with More Than 1 Employees
--Task: Retrieve the department names that have more than 1 employees.
select *from Employees;
select distinct DepartmentName from Employees where DepartmentName = 
	(select DepartmentName from Employees group by DepartmentName having count(DepartmentName) > 1);

--Assignment 3: Retrieve Products with a Price Higher Than the Maximum Price of Category 'A'
--Task: Retrieve the product names and prices of products that have a price higher than the maximum price of products in category 'A'.
select *from Products;
select *from Categories;
select ProductName, Price from Products where Price > 
	(select max(Price) from Products where CategoryID = (Select CategoryID from Categories where CategoryName = 'A'));

--Assignment 4: Retrieve Employees Who Work in Departments with Average Salary Higher Than 50,000
--Task: Retrieve the names of employees who work in departments where the average salary is higher than 50,000.
select *from Employees;
select EmployeeFullName from Employees where DepartmentName in 
	(select DepartmentName from Employees group by DepartmentName having avg(Salary) > 50000);

--Assignment 5: Find Employees Who Earn More Than Their Department's Average Salary
--Task: Retrieve the names of employees who earn more than the average salary of their department.
select *from Employees;
SELECT EmployeeFullName from Employees E where Salary > (
    select avg(Salary) from Employees where DepartmentName = E.DepartmentName); 

--Assignment 6: Find Customers Who Have Not Placed Any Orders
--Task: Retrieve the names of customers who have not placed any orders.
select *from Customers;
select *from Orders;
select CustomerName from Customers where CustomerID not in (
	select CustomerID from Orders);

--Assignment 7: Retrieve Top 3 Highest-Paid Employees in Each Department
--Task: Retrieve the top 3 highest-paid employees in each department.


--Assignment 8: Find Products That Have Never Been Ordered
--Task: Retrieve the names of products that have never been ordered.
select *from Products;
select *from OrderDetails;
select ProductName from Products where ProductID not in (
	select ProductID from OrderDetails);


--SQL Server assignments that focus on different types of joins 
--(INNER JOIN, LEFT JOIN, RIGHT JOIN, FULL OUTER JOIN, CROSS JOIN)

--Assignment 1: Retrieve Employees and Their Department Names (INNER JOIN)
--Task: Retrieve the employee names and their corresponding department names.
select *from Employees;
select *from Departments;
select Employees.EmployeeFullName, Departments.DepartmentName 
from Employees inner join Departments on Employees.DepartmentID = Departments.DepartmentID;

--Assignment 2: Retrieve All Employees and Their Department Names, Including Those Without Departments (LEFT JOIN)
--Task: Retrieve the employee names and their corresponding department names. 
--Include employees who are not assigned to any department.
select *from Employees;
select *from Departments;
select Employees.EmployeeFullName, Departments.DepartmentName 
from Employees left outer join Departments on Employees.DepartmentID = Departments.DepartmentID;

--Assignment 3: Retrieve All Departments and the Employees Working in Them (RIGHT JOIN)
--Task: Retrieve all departments and their respective employees. Include departments even if they don’t have any employees.
select *from Employees;
select *from Departments;
select Departments.DepartmentName, Employees.EmployeeFullName 
from Employees right outer join Departments on Employees.DepartmentID = Departments.DepartmentID;

--Assignment 4: Retrieve All Employees and Departments, Including Those Without Matches (FULL OUTER JOIN)
--Task: Retrieve all employees and all departments, including employees without a department and departments without employees.
select *from Employees;
select *from Departments;
select Employees.EmployeeFullName, Departments.DepartmentName 
from Employees full outer join Departments on Employees.DepartmentID = Departments.DepartmentID;

--Assignment 5: Retrieve Orders and the Customers Who Placed Them (INNER JOIN)
--Task: Retrieve order IDs and customer names for all orders.
select *from Customers;
select *from Orders;
select Orders.OrderID, Customers.CustomerName from Orders inner join Customers on Orders.CustomerID = Customers.CustomerID;

--Assignment 6: Retrieve Orders and Customers, Including Customers Without Orders (LEFT JOIN)
--Task: Retrieve all customers and their respective orders. Include customers even if they haven’t placed any orders.
select *from Customers;
select *from Orders;
select Customers.CustomerName, Orders.OrderID, Orders.OrderDate, Orders.TotalAmount 
from Customers left outer join Orders on Orders.CustomerID = Customers.CustomerID;

--Assignment 7: Retrieve Products and Their Categories (INNER JOIN)
--Task: Retrieve product names and their respective category names.
select *from Products;
select *from Categories;
select Products.ProductName, Categories.CategoryName from Products inner join Categories on Categories.CategoryID = Products.CategoryID; 

--Assignment 8: Retrieve All Categories and Products, Including Categories Without Products (RIGHT JOIN)
--Task: Retrieve all categories and the products in each category. Include categories that don’t have any products.
select *from Products;
select *from Categories;
select Categories.CategoryName, Products.ProductName from Products right join Categories on Categories.CategoryID = Products.CategoryID; 

--Assignment 9: Retrieve Employees and Their Managers (Self-Join)
--Task: Retrieve the employee names and the names of their managers.
select *from Employees;
select E.EmployeeFullName, M.EmployeeFullName as ManagerName From Employees E join Employees M on E.ManagerID = M.EmployeeID;

--Assignment 10: Get All Possible Combinations of Products and Orders (CROSS JOIN)
--Task: Retrieve all possible combinations of products and orders (cartesian product).
select *from Products;
select *from Orders;
Select *from Products cross join Orders;


--SQL Server assignments using the GROUP BY and HAVING clauses

--Assignment 1: Find the Average Salary in Each Department
--Task: Retrieve the department name and the average salary of employees in each department.
--Only display departments where the average salary is greater than 50,000.
select *from Employees;
select *from Departments;
select D.DepartmentName, avg(E.Salary) as AverageSalary from Employees E inner join Departments D 
on D.DepartmentID = E.DepartmentID group by D.DepartmentName having avg(E.Salary) > 50000;

--Assignment 2: Count the Number of Employees in Each Department
--Task: Retrieve the department name and the total number of employees in each department.
--Only display departments that have more than 1 employees.
select *from Employees;
select *from Departments;
select D.DepartmentName, Count(*) as CountOfEmployees from Employees E inner join Departments D 
on D.DepartmentID = E.DepartmentID group by D.DepartmentName having count(D.DepartmentName) > 1;

--Assignment 3: Find the Maximum and Minimum Salary in Each Department
--Task: Retrieve the department name, maximum salary, and minimum salary for each
--department. Only include departments where the minimum salary is greater than 30,000.
select *from Employees;
select *from Departments;
select D.DepartmentName, max(E.Salary) as MaximumSalary, min(E.Salary) as MinimumSalary from Employees E inner join Departments D 
on D.DepartmentID = E.DepartmentID group by D.DepartmentName having min(E.Salary) > 30000;

--Assignment 4: Find the Total Sales by Each Salesperson
--Task: Retrieve the employee name and total sales made by each salesperson. Only display
--salespersons who have made total sales of more than 10,000.
 select *from Employees;
 select *from SalesDetails;
 select E.EmployeeFullName, sum(S.Amount) as TotalSales from Employees E inner join SalesDetails S 
 on E.EmployeeID = S.EmployeeID group by E.EmployeeFullName having sum(S.Amount) > 10000;

--Assignment 5: Find the Number of Orders by Each Customer
--Task: Retrieve the customer name and the total number of orders placed by each customer. Only
--display customers who have placed more than 1 orders.
select *from Customers;
select *from Orders;
select C.CustomerName, count(*) as TotalNumberOfOrders from Customers C inner join Orders O 
on C.CustomerID = O.CustomerID group by C.CustomerName having count(C.CustomerName)>1;
