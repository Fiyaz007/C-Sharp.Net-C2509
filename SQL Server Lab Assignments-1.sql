--SQL Server Lab Assignments - 1

--Assignment 1 : Create a Database and Table
create database CompanyDB
use CompanyDB

create table Employees(
EmployeeID int primary key identity(101,1) NOT NULL,
FirstName varchar(50),
LastName varchar(50),
Department varchar(50),
Salary Decimal(10,2)
)

--Assignment 2 : Insert Data into a Table
insert into Employees(FirstName, LastName, Department, Salary)
values('John', 'Doe', 'HR', 50000),
('Jane', 'Smith', 'IT', 60000),
('David', 'Lee', 'Marketing', 55000);

--Assignment 3 : Select and Query Data
--Retrieve all employee records from the Employees table.
select *from Employees;

--Retrieve the FirstName, LastName, and Salary of employees in the IT department and salary greater than 5000
select FirstName, LastName, Salary from Employees where Department = 'IT' and Salary > 5000;

--Find the highest salary from the Employees table.
select max(Salary) as MaxSalary from Employees;

--Assignment 4 : Update Data in a Table
--Update the salary of John Doe to 55000.
update Employees set Salary = 55000 where FirstName = 'John';

--Change the department of Jane Smith to Marketing.
update Employees set Department = 'Marketing' where FirstName = 'Jane';

--Assignment 5 : Delete Data from a Table
--Delete the record of David Lee from the Employees table.
Delete Employees where FirstName =  'David';

--Delete all employees in the Marketing department.
Delete Employees where Department = 'Marketing';

Drop table Employees;


--Assignment 6 : Product Management
--1: Create a tabled named Products and insert below records in the table.
create table Products(
ProductID int primary key identity(1,1),
ProductName varchar(50),
Category varchar(50),
Price int,
Stock int
);

insert into Products values ('Laptop', 'Electronics', 1000, 50),
('Mouse', 'Electronics', 20, 200),
('Keyboard', 'Electronics', 30, 150),
('Printer', 'Electronics', 150, 75);

--2: Select all columns from the Products table
select *from Products;

--3: Select products, sorted by their price in descending order.
select *from Products order by Price desc;

--4: Update the price of the "Mouse" to 25.
update Products set Price = 25 where ProductName = 'Mouse';

--5: Delete the product with ProductID 2 (Mouse).
delete Products where ProductID =2;

--6: Select products sorted by ProductName in alphabetical order.
select *from Products order by ProductName asc;


--Assignment 7: Library Management
--1: Create a tabled named Books with the below structure and insert below records in the table.
create table Books(
BookID int primary key identity(1,1),
Title varchar(50),
Author varchar(50),
PublishedYear int,
AvailableCopies int
);

insert into Books values ('The Great Gatsby', 'F. Scott Fitzgerald', 1925, 3),
('1984', 'George Orwell', 1949, 2),
('To Kill a Mockingbird', 'Harper Lee', 1960, 5),
('Brave New World', 'Aldous Huxley', 1932, 4);

select *from Books;

--2: Update the available copies of "1984" to 5.
update Books set AvailableCopies = 5 where Title = '1984';

--3: Delete the book with BookID 1 (The Great Gatsby).
delete Books where BookID = 1;

--4: Write a query to Select books published after 1950.
select *from Books where PublishedYear > 1950;


--Assignment 8: Customer Management
--1: Create a Customers table containing details about customers with the below details.
create table Customers(
CustomerID int primary key identity(201,1),
CustomerName varchar(50),
Email varchar(50),
PhoneNumber varchar(50)
);

insert into Customers values ('Alice Johnson', 'alice@example.com', '555-1234'),
('Bob Smith', 'bob@example.com', '555-5678'),
('Charlie Brown', 'charlie@example.com', '555-8765');

select *from Customers;

--2: Insert a new customer into the Customers table with the following details:
--	a. CustomerID: 204
--	b. CustomerName: David Wilson
--	c. Email: david@example.com
--	d. PhoneNumber: 555-4321
insert into Customers values ('David Wilson', 'david@example.com', '555-4321');

--3: Update the phone number of "Alice Johnson" to "555-9999".
update Customers set PhoneNumber = '555-9999' where CustomerName = 'Alice Johnson';

--4: Delete the customer with CustomerID 202 (Bob Smith).
delete Customers where CustomerID = 202;


--Assignment 9: Orders Management
--1: Create an Orders table that contains information about customer orders with the below details:
create table Orders (
OrderID int primary key identity(301,1),
CustomerID int,
OrderDate date,
TotalAmount decimal(10,2)
);

insert into Orders values (201, '2024-09-01', 250.00),(202, '2024-09-02', 150.00),(203, '2024-09-03', 200.00);

select *from Orders;

--2: Insert a new order into the Orders table with the following details:
	--a. OrderID: 304
	--b. CustomerID: 204
	--c. OrderDate: 2024-09-04
	--d. TotalAmount: 300.00
insert into Orders values (204, '2024-09-04', 300.00);

--3: Update the TotalAmount for OrderID 301 to 275.00.
update Orders set TotalAmount = 275.00 where OrderID = 301;

--4: Delete the order with OrderID 302.
delete Orders where OrderID = 302;

--5: Select orders with a total amount greater than 200.
select *from Orders where TotalAmount > 200;

--6: Select only the OrderID and TotalAmount for all orders.
select OrderID, TotalAmount from Orders;


--Assignment 10: Primary Key
--Create a Students table with a StudentID as the primary key and include the following columns:
--FirstName, LastName, and Email. Insert three records into the table.
create table Students (
StudentID int primary key identity(1,1),
FirstName varchar(50),
LastName varchar(50),
Email varchar(50)
);

insert into Students values ('John', 'Doe', 'john.doe@example.com'), ('Jane', 'Smith', 'jane.smith@example.com'), ('Mike', 'Johnson', 'mike.johnson@example.com');

select *from Students;

--Assignment 11: Foreign Key
--Create a Courses table with a CourseID as the primary key. Create a Enrollments table with a
--StudentID as a foreign key referencing the Students table and a CourseID as a foreign key
--referencing the Courses table. Insert sample data into both tables.
create table Courses (CourseID int primary key identity(101,1), CourseName varchar(50));

insert into Courses values ('DotNet'),('Python'),('Java');

select *from Courses;

create table Enrollments (
StudentID int foreign key references Students(StudentID),
CourseID int foreign key references Courses(CourseID),
EnrolledDate date
);

insert into Enrollments values (1, 103, '2024-10-01'), (1, 102, '2024-10-05'), (2, 101, '2024-09-07'),(3, 102, '2024-07-19');

select *from Enrollments;
--insert into Enrollments values (1, 105, '2024-10-03');

--Assignment 12: Composite Key
--Create an OrderDetails table that contains OrderID, ProductID, and Quantity. Define a composite primary key using OrderID and ProductID.
create table OrderDetails (
    OrderID int,
    ProductID int,
    Quantity int,
    primary key (OrderID, ProductID)
);

insert into OrderDetails values (1001, 2001, 10), (1001, 2002, 15);
select *from OrderDetails;

--Assignment 13: Candidate Key and Alternate Key
--Create a Users table with UserID as the primary key, and include Email and Username as
--candidate keys. Set the Email column as a unique key.
Create table Users (
	UserID int primary key,
	Email varchar(50) unique,
	UserName varchar(50)
);

--Assignment 14: Surrogate Key
--Create a Products table with an AutoID as a surrogate key that automatically increments. Include
--ProductName and Price columns.
create table Product_s(
	AutoID int primary key identity(1,1),
	ProductName varchar(50),
	Price int
);

--Assignment 15: Natural Key
--Create a Employees table that uses SSN (Social Security Number) as a natural key. Include
--columns for FirstName, LastName, and Position.
create table Employee(
	SSN int primary key,
	FirstName varchar(50),
	LastName varchar(50),
	Position varchar(50)
);

--Assignment 16: Unique Key
--Create a Customers table with a CustomerID as the primary key and a PhoneNumber column
--that must be unique.
create table Customer(
	CustomerID int primary key identity(201,1),
	PhoneNumber varchar(50) unique
);


--Assignment 17: Basic View Creation
--1: Create a simple view named EmployeeView that displays the FirstName, LastName, and
--Department columns from the Employees table.
CREATE VIEW EmployeeView 
AS SELECT FirstName, LastName, Department FROM Employees;

--2: Query the view to display the details
SELECT *FROM EmployeeView;


--Assignment 18: Updating Data Through a View
--1: Create a view named EditableEmployeeView that shows EmployeeID, FirstName, LastName, and Salary.
CREATE VIEW EditableEmployeeView 
AS SELECT EmployeeID, FirstName, LastName, Salary FROM Employees;

--2: Update the salary of an employee using the view.
update EditableEmployeeView set Salary = 75000 where EmployeeID = 101; 
SELECT *FROM EditableEmployeeView;

--3: Verify the update
SELECT *FROM Employees;


--Assignment 19: View with Calculated Columns
--1: Create a view named EmployeeSalaryBonusView that displays each employee’s 
--FirstName, LastName, Salary, and a calculated column Bonus (10% of the salary).
CREATE VIEW EmployeeSalaryBonusView 
AS SELECT FirstName, LastName, Salary ,Salary * 0.1 as Bonus FROM Employees;

--2: Query the view
SELECT *FROM EmployeeSalaryBonusView;


--Assignment 20: Altering a View
--1: Alter the EmployeeView from Assignment 1 to include a new column Salary.
ALTER VIEW EmployeeView 
AS SELECT FirstName, LastName, Department,Salary FROM Employees;

--2: Verify the view with the updated column.
SELECT *FROM EmployeeView;


--Assignment 21: View with Parameters (Simulated via Filters)
--1: Create a view named FilteredEmployeeView from employees table that displays
--EmployeeID,FirstName,LastName & Department.
CREATE VIEW FilteredEmployeeView
AS SELECT EmployeeID, FirstName, LastName, Department FROM Employees;

SELECT *FROM FilteredEmployeeView;

--2: Use a query on the view to return employees in a specific department (e.g.,Department = 'HR').
SELECT *FROM FilteredEmployeeView WHERE Department = 'HR';


--Assignment 22: Dropping a View
--1: Drop the EmployeeView that was created in the previous assignments.
DROP VIEW EmployeeView;

--2: Try to query the view again.
SELECT *FROM EmployeeView;
