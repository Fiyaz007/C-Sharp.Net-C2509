using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes_Objects_Assignments
{
    //C# Assignments on Classes & Objects
    //----------------------------------------------------------------------------------------------------
    //Assignment 1: Circle Class
    public class Circle
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius cannot be negative");
                }
                radius = value;
            }
        }
    }

    //----------------------------------------------------------------------------------------------------
    ////Assignment 2: Employee Class
    public class Employee
    {
        private string name;
        private int salary;
        public Employee(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative");
                }
                salary = value;
            }
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Assignment 3: Library Management System
    public class Book
    {
        public string title;
        public string author;
        public int iSBN;
        public Book(string title, string author, int iSBN)
        {
            this.title = title;
            this.author = author;
            this.iSBN = iSBN;
        }
    }
    public class Library
    {
        private List<Book> books;
        public Library()
        {
            books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book Added Successfully....");
        }
        public void RemoveBook(int isbn)
        {
            Book bookToRemove = books.Find(b => b.iSBN == isbn);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine("\nBook removed Successfully....");
            }
            else
                Console.WriteLine("\nBook not Found");
        }
        public void DiplayBookDetails()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("\nNo books in the library.");
            }
            else
            {
                Console.WriteLine("\nBooks in the library:");
                foreach (Book book in books)
                {
                    Console.WriteLine($"\nTitle: {book.title}\nAuthor: {book.author}\nISBN: {book.iSBN}");
                }
            }

        }
    }

    //----------------------------------------------------------------------------------------------------
    //Assignment 4: Banking System
    public class BankAccount
    {
        public int accountNumber;
        public string accountHolder;
        private int balance;
        public BankAccount(int accountNumber, string accountHolder, int balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            Balance = balance;
        }
        public int Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("\nBalance cannot be negative.");
                }
                balance = value;
            }
        }
        public void Deposit(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("\nDeposit amount must be positive.");
            }
            Balance += amount;
            Console.WriteLine($"\nDeposited {amount}. New Balance: {Balance}");
        }
        public void Withdraw(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("\nWithdrawal amount must be positive");
            }
            if (amount > Balance)
            {
                throw new ArgumentException("\nInsufficient Balance.");
            }
            Balance -= amount;
            Console.WriteLine($"\nWithdrew {amount}. New Balance: {Balance}");
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"\nAccount Number: {accountNumber}\nAccount Holder: {accountHolder}\nBalance: {Balance}");
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Assignment 5: Student Management System
    public class Student
    {
        public string studentName;
        public int studentID;
        private List<int> grades;
        public Student(string studentName, int studentID)
        {
            this.studentName = studentName;
            this.studentID = studentID;
            grades = new List<int>();
        }
        public void AddGrade(int grade)
        {
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Grade must be between 0 and 100.");
            }
            else
            {
                grades.Add(grade);
                Console.WriteLine($"Grade: {grade} added");
            }
        }
        public double CalculateAverageGrade()
        {
            if (grades.Count == 0)
            {
                Console.WriteLine("No grades available to calculate average.");
                return 0;
            }
            return grades.Average();
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine($"\nStudent Name: {studentName}\nStudent ID: {studentID}");
            Console.WriteLine($"Grades: {string.Join(", ", grades)}");
            Console.WriteLine($"Average Grade: {CalculateAverageGrade():F2}");
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Assignment 6: Inventory System
    public class Item
    {
        public string itemName;
        private int stock;
        private int price;
        public Item(string itemName, int stock, int price)
        {
            this.itemName = itemName;
            this.stock = stock;
            this.price = price;
        }
        public int Stock
        {
            get { return stock; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Stock cannot be negative.");
                stock = value;
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative.");
                price = value;
            }
        }
        public void DisplayItemInfo()
        {
            Console.WriteLine($"Item Name: {itemName}, Stock: {Stock}, Price: {Price}");
        }
    }
    public class Inventory
    {
        private List<Item> items;
        public Inventory() 
        { 
            items = new List<Item>();
        }
        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine($"Item {item.itemName} added to inventory.");
        }
        public void RemoveItem(string itemName)
        {
            Item item = items.Find(x => x.itemName == itemName);
            if (item != null)
            {
                items.Remove(item);
                Console.WriteLine($"Item {itemName} removed from inventory.");
            }
            else
                Console.WriteLine($"Item {itemName} not found in inventory.");
        }
        public void UpdatePrice(string itemName, int newPrice)
        {
            Item item = items.Find(x => x.itemName == itemName);
            if (item != null)
            {
                item.Price = newPrice;
                Console.WriteLine($"Price for {itemName} updated to {newPrice}.");
            }
            else
                Console.WriteLine($"Item {itemName} not found in inventory.");
        }
        public void UpdateStock(string itemName, int newStock)
        {
            Item item = items.Find(x => x.itemName == itemName);
            if (item != null)
            {
                item.Stock = newStock;
                Console.WriteLine($"Stock for {itemName} updated to {newStock}.");
            }
            else
                Console.WriteLine($"Item {itemName} not found in inventory.");
        }
        public void DisplayAllItems()
        {
            if (items.Count == 0)
                Console.WriteLine("No items in inventory.");
            else
                foreach (Item item in items)
                {
                    item.DisplayItemInfo();
                }
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Assignment 7: E-commerce System
    public class Product
    {
        public string Name;
        private double price;
        private int stock;
        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative.");
                }
                price = value;
            }
        }
        public int Stock
        {
            get { return stock; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Stock cannot be negative.");
                }
                stock = value;
            }
        }
        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product Name: {Name}, Price: {Price:C}, Stock: {Stock}");
        }
    }
    public class Order
    {
        public Product Product;
        public int Quantity;
        public Order(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
    public class ECommerceSystem
    {
        private List<Product> products;
        private List<Order> orders;
        public ECommerceSystem()
        {
            products = new List<Product>();
            orders = new List<Order>();
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine($"Product {product.Name} added to the system.");
        }
        public void CreateOrder(string productName, int quantity)
        {
            var product = products.Find(p => p.Name == productName);
            if (product != null)
            {
                if (product.Stock >= quantity)
                {
                    product.Stock -= quantity;
                    Order newOrder = new Order(product, quantity);
                    orders.Add(newOrder);
                    Console.WriteLine($"Order created for {quantity} of {product.Name}.");
                }
                else
                {
                    Console.WriteLine($"Insufficient stock for {product.Name}. Available: {product.Stock}, Requested: {quantity}.");
                }
            }
            else
            {
                Console.WriteLine($"Product {productName} not found.");
            }
        }
        public void DisplayAllProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products available.");
            }
            else
            {
                foreach (var product in products)
                {
                    product.DisplayProductInfo();
                }
            }
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Assignment 8: Print Class
    public class Print
    {
        public void PrintData(string data)
        {
            Console.WriteLine($"String: {data}");
        }
        public void PrintData(int data)
        {
            Console.WriteLine($"Integer: {data}");
        }
        public void PrintData(int[] data)
        {
            Console.WriteLine("Integer Array: " + string.Join(", ", data));
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Assignment 9: Rectangle Class
    public class Rectangle
    {
        public int CalculateArea(int width, int height)
        {
            return width * height;
        }
        public int CalculateArea(int side)
        {
            return side * side;
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Assignment 10: Time Class
    public class Time
    {
        private int hours;
        private int minutes;
        private int seconds;
        public void SetTime(int hours, int minutes)
        {

            this.hours = hours;
            this.minutes = minutes;
            this.seconds = 0;
        }
        public void SetTime(int seconds)
        {
            hours = (seconds / 3600) % 24; // Hours in 24-hour format
            minutes = (seconds % 3600) / 60;
            this.seconds = seconds % 60;
        }
        public void DisplayTime()
        {
            Console.WriteLine($"{hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
    //----------------------------------------------------------------------------------------------------
}
