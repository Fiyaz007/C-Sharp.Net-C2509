using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects_Assignments
{
    //C# Assignments on Classes & Objects
    //----------------------------------------------------------------------------------------------------
    //Assignment 11: Initializing a Static Field
    public class Bank
    {
        private static double interestRate;
        private double balance;
        static Bank()
        {
            interestRate = 4.3;
        }
        public Bank(double initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentException("\nBalance cannot be negative.");
            }
            balance = initialBalance;
        }
        public void DisplayBalance()
        {
            Console.WriteLine($"Account Balance: ${balance}");
        }
        public static double GetInterestRate()
        {
            return interestRate;
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Assignment 12: Counting Objects with Static and Instance Fields
    public class Car
    {
        private static int carCount;
        static Car()
        {
            carCount = 0;
            Console.WriteLine("Car counter initialized.");
        }
        public Car()
        {
            carCount++;
        }
        public static int GetCarCount()
        {
            return carCount;
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Assignment 13: Initializing Constants with Static Block
    public class MathOperations
    {
        public static readonly double PI;
        static MathOperations()
        {
            PI = 3.14;
            Console.WriteLine("Pi initialized with value: " + PI);
        }
        public static double CalculateCircleArea(double radius)
        {
            return PI * radius * radius;
        }
        public static double CalculateCircumference(double radius)
        {
            return 2 * PI * radius;
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Assignment 14: Initializing Configuration with Static Constructor
    public class Configuration
    {
        public static readonly string ApplicationName;
        public string UserName;
        public string Theme;
        static Configuration()
        {
            ApplicationName = "Sample App";
            Console.WriteLine("System-wide configuration loaded:");
            Console.WriteLine($"Application Name: {ApplicationName}");
        }
        public Configuration(string userName, string theme)
        {
            UserName = userName;
            Theme = theme;
        }
        public void DisplayUserPreferences()
        {
            Console.WriteLine($"User Name: {UserName}");
            Console.WriteLine($"Preferred Theme: {Theme}");
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Assignment15: Implementing and Understanding Copy Constructor
    public class Person
    {
        public string Name;
        public string Address;
        public int Age;
        public Person(string name, string address, int age)
        {
            Name = name;
            Address = address;
            Age = age;
        }
        public Person(Person person)
        {
            Name = person.Name;
            Address = person.Address;
            Age = person.Age;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}");
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Assignment 16: Identifying the Need for Chained Constructors
    public class Cars
    {
        public string Make;
        public string Model;
        public int Year;
        public double Price;
        public Cars(string make)
        {
            Make = make;
        }
        public Cars(string make, string model) : this(make)
        {
            Model = model;
        }
        public Cars(string make, string model, int year) : this(make, model)
        {
            Year = year;
        }
        public Cars(string make, string model, int year, double price) : this(make, model, year)
        {
            Price = price;
        }
        public void DisplayCarDetails()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price:F2}");
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Assignment 17: Understanding the Need for Constructor Overloading
    public class Products
    {
        public string Name;
        public double Price;
        public double Discount;
        public Products(string name)
        {
            Name = name;
            Price = 0; 
            Discount = 0;
        }
        public Products(string name, double price) : this(name)
        {
            Price = price;
        }
        public Products(string name, double price, double discount) : this(name, price)
        {
            Discount = discount;
        }
        public double CalculateFinalPrice()
        {
            if (Discount > 0 && Discount <= 100)
            {
                return Price - (Price * (Discount / 100));
            }
            return Price;
        }
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Discount: {Discount}%");
            Console.WriteLine($"Final Price after Discount: {CalculateFinalPrice()}");
            Console.WriteLine();
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Assignment 18: Exploring Different Ways to Initialize Objects
    public class Product_s
    {
        public string Name;
        public double Price;
        public string Category;
        public Product_s(string name, double price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
        public Product_s()
        {
            Name = "Unknown Product";
            Price = 0.0;
            Category = "Uncategorized";
        }
        public static Product_s CreateProduct(string name, double price, string category)
        {
            return new Product_s(name, price, category);
        }
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Category: {Category}");
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Assignment 19: Exploring Initialization Using Tuples and Records
    //It's on another file ClassesAssignment(19).cs
    //----------------------------------------------------------------------------------------------------
    //Assignment 20: Shopping Cart
    public class ShoppingCart
    {
        public class Product
        {
            public string Name;
            public double Price;
            public int Quantity;
            public Product(string name, double price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
        }
        private List<Product> products = new List<Product>();
        public void AddProduct(string name, double price, int quantity)
        {
            Product product = new Product(name, price, quantity);
            products.Add(product);
            Console.WriteLine($"Added {quantity} of '{name}' to the cart.");
        }
        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (var product in products)
            {
                totalPrice += product.Price * product.Quantity;
            }
            return totalPrice;
        }
        public void DisplayCart()
        {
            Console.WriteLine("\nProducts in Shopping Cart:");
            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
            }
            Console.WriteLine($"Total Price: {CalculateTotalPrice()}");
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Assignment 21: Banking System
    public class Banks
    {
        // Nested Customer class
        public class Customer
        {
            public string Name;
            public List<Account> Accounts;
            public Customer(string name)
            {
                Name = name;
                Accounts = new List<Account>();
            }
            public void AddAccount(string accountNumber, double initialBalance)
            {
                Account newAccount = new Account(accountNumber, initialBalance);
                Accounts.Add(newAccount);
                Console.WriteLine($"Account {accountNumber} with balance {initialBalance:C} added for customer {Name}.");
            }
        }
        // Nested Account class
        public class Account
        {
            public string AccountNumber;
            public double Balance;
            public Account(string accountNumber, double initialBalance)
            {
                AccountNumber = accountNumber;
                Balance = initialBalance;
            }
        }
        private List<Customer> customers = new List<Customer>();
        public void AddCustomer(string name)
        {
            Customer newCustomer = new Customer(name);
            customers.Add(newCustomer);
            Console.WriteLine($"Customer '{name}' added to the bank.");
        }
        public Customer FindCustomer(string name)
        {
            return customers.Find(customer => customer.Name == name);
        }
        public void DisplayCustomerDetails()
        {
            Console.WriteLine("\nCustomer Account Details:");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer: {customer.Name}");
                if (customer.Accounts.Count == 0)
                    Console.WriteLine("  No accounts available.");
                else
                {
                    foreach (var account in customer.Accounts)
                        Console.WriteLine($"  Account Number: {account.AccountNumber}, Balance: {account.Balance:C}");
                }
                Console.WriteLine();
            }
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Assignment 22: University System
    public class University
    {
        // Nested Department class
        public class Department
        {
            public string Name;
            public List<Course> Courses;
            public Department(string name)
            {
                Name = name;
                Courses = new List<Course>();
            }
            public void AddCourse(string courseName, string courseCode, int credits)
            {
                Course newCourse = new Course(courseName, courseCode, credits);
                Courses.Add(newCourse);
                Console.WriteLine($"Course '{courseName}' added to the department '{Name}'.");
            }
        }
        // Nested Course class
        public class Course
        {
            public string CourseName;
            public string CourseCode;
            public int Credits;
            public Course(string courseName, string courseCode, int credits)
            {
                CourseName = courseName;
                CourseCode = courseCode;
                Credits = credits;
            }
        }
        private List<Department> departments = new List<Department>();
        public void AddDepartment(string name)
        {
            Department newDepartment = new Department(name);
            departments.Add(newDepartment);
            Console.WriteLine($"Department '{name}' added to the university.");
        }
        public Department FindDepartment(string name)
        {
            return departments.Find(department => department.Name == name);
        }
        public void DisplayCourseDetails()
        {
            Console.WriteLine("\nDetails of courses in the University:");
            foreach (var department in departments)
            {
                Console.WriteLine($"  Department: {department.Name}");
                if (department.Courses.Count == 0)
                    Console.WriteLine("    No courses available.");
                else
                {
                    foreach (var course in department.Courses)
                        Console.WriteLine($"    Course Name: {course.CourseName}, Course Code: {course.CourseCode}, Credits: {course.Credits}");
                }
                Console.WriteLine();
            }
        }
    }
    //----------------------------------------------------------------------------------------------------
}