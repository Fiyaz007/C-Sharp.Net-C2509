using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# Assignments on Classes & Objects
            //----------------------------------------------------------------------------------------------------
            //Assignment 1: Circle Class
            //Circle circle = new Circle();
            //circle.Radius = 7;
            //Console.WriteLine(circle.Radius);

            //try
            //{
            //    circle.Radius = -17;
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //Console.ReadLine();

            //----------------------------------------------------------------------------------------------------
            //Assignment 2: Employee Class
            //Employee employee = new Employee("Fiyaz Nazeer", 25000);
            //Console.WriteLine($"Employee: {employee.Name}, \nSalary: {employee.Salary}");

            //employee.Salary = 45000;
            //Console.WriteLine($"Updated Salary: {employee.Salary}");

            //try
            //{
            //    employee.Salary = -10000;
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //Console.ReadLine();

            //----------------------------------------------------------------------------------------------------
            //Assignment 3: Library Management System
            //Library library = new Library();
            //library.AddBook(new Book("Murder on the Orient Express", "Agatha Christie", 13579));
            //library.AddBook(new Book("The Hobbit", "J.R.R. Tolkien", 24680));
            //library.AddBook(new Book("Pride and Prejudice", "Jane Austen", 147852));

            //library.DiplayBookDetails();

            //Console.WriteLine("\nEnter the ISBN number of book to be deleted: ");
            //int iSBN = Convert.ToInt32(Console.ReadLine());
            //library.RemoveBook(iSBN);

            //library.DiplayBookDetails();
            //Console.ReadLine();

            //----------------------------------------------------------------------------------------------------
            //Assignment 4: Banking System
            //try
            //{
            //    BankAccount account = new BankAccount(1234, "Fiyaz Nazeer", 75000);
            //    account.DisplayAccountInfo();

            //    account.Deposit(5000);
            //    account.DisplayAccountInfo();

            //    account.Withdraw(30000);
            //    account.DisplayAccountInfo();

            //    account.Withdraw(55000);
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //Console.ReadLine();

            //----------------------------------------------------------------------------------------------------
            //Assignment 5: Student Management System
            //Student student1 = new Student("Fiyaz Nazeer", 101);

            //student1.AddGrade(85);
            //student1.AddGrade(90);
            //student1.AddGrade(78);
            //student1.DisplayStudentDetails();
            //Console.ReadLine();

            //----------------------------------------------------------------------------------------------------
            //Assignment 6: Inventory System
            //Inventory inventory = new Inventory();

            //// Add items to inventory
            //inventory.AddItem(new Item("Laptop", 10, 800));
            //inventory.AddItem(new Item("Smartphone", 22, 500));
            //inventory.AddItem(new Item("Speakers", 9, 1000));
            //Console.WriteLine();

            //// Display all items
            //inventory.DisplayAllItems();
            //Console.WriteLine();

            //// Update stock and price
            //inventory.UpdateStock("Laptop", 17);
            //Console.WriteLine();
            //inventory.UpdatePrice("Smartphone", 750);
            //Console.WriteLine();

            //// Display updated inventory
            //inventory.DisplayAllItems();
            //Console.WriteLine();

            //// Remove an item from the inventory
            //inventory.RemoveItem("Speakers");
            //Console.WriteLine();

            //// Display updated inventory
            //inventory.DisplayAllItems();
            //Console.ReadLine();

            //----------------------------------------------------------------------------------------------------
            //Assignment 7: E-commerce System
            //ECommerceSystem ecommerceSystem = new ECommerceSystem();

            //// Add products to the system
            //ecommerceSystem.AddProduct(new Product("Laptop", 999.99, 18));
            //ecommerceSystem.AddProduct(new Product("Smartphone", 599.99, 24));
            //ecommerceSystem.AddProduct(new Product("Headphones", 249.99, 26));
            //Console.WriteLine();

            //// Display all products
            //ecommerceSystem.DisplayAllProducts();
            //Console.WriteLine();

            //// Create orders
            //ecommerceSystem.CreateOrder("Laptop", 3);
            //ecommerceSystem.CreateOrder("Smartphone", 6);
            //ecommerceSystem.CreateOrder("Headphones", 32); // Exceeding stock

            //// Display updated product information
            //Console.WriteLine("\nUpdated Product Information:");
            //ecommerceSystem.DisplayAllProducts();
            //Console.ReadLine();

            //----------------------------------------------------------------------------------------------------
            //Assignment 8: Print Class
            //Print print = new Print();
            //print.PrintData("Fiyaz Nazeer");//print string
            //print.PrintData(22);//print integer
            //print.PrintData(new int[] { 1, 3, 5, 7, 9 });//print integer array
            //Console.ReadLine();

            //----------------------------------------------------------------------------------------------------
            //Assignment 9: Rectangle Class
            /*Rectangle rectangle = new Rectangle();

            // Calculate area of a rectangle
            int width = 7;
            int height = 17;
            int rectangleArea = rectangle.CalculateArea(width, height);
            Console.WriteLine($"Area of Rectangle: {rectangleArea}");

            // Calculate area of a square
            int side = 13;
            int squareArea = rectangle.CalculateArea(side);
            Console.WriteLine($"Area of Square : {squareArea}");
            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Assignment 10: Time Class
            /*Time time = new Time();

            // Set time using hours and minutes
            time.SetTime(15, 19);
            Console.Write("Time set using hours and minutes: ");
            time.DisplayTime();

            // Set time using seconds
            time.SetTime(4598);
            Console.Write("\nTime set using seconds: ");
            time.DisplayTime();
            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Assignment 11: Initializing a Static Field
            /*Console.WriteLine($"Interest Rate: {Bank.GetInterestRate()}%");

            Bank account = new Bank(1000.0);
            account.DisplayBalance();
            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Assignment 12: Counting Objects with Static and Instance Fields
            /*Console.WriteLine($"Initial Car Count: {Car.GetCarCount()}");

            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            // Display the updated count
            Console.WriteLine($"Total Cars after created instances: {Car.GetCarCount()}");
            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Assignment 13: Initializing Constants with Static Block
            /*Console.WriteLine($"Value of Pi: {MathOperations.PI}");
            double radius = 5.0;
            double area = MathOperations.CalculateCircleArea(radius);
            double circumference = MathOperations.CalculateCircumference(radius);

            Console.WriteLine($"\nradius: {radius}");
            Console.WriteLine($"Area of a circle: {area}");
            Console.WriteLine($"Circumference of a circle: {circumference}");
            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Assignment 14: Initializing Configuration with Static Constructor
            /*Configuration user1 = new Configuration("Alice", "Dark");
            Console.WriteLine("\nUser 1 Preferences:");
            user1.DisplayUserPreferences();

            Configuration user2 = new Configuration("Bob", "Light");
            Console.WriteLine("\nUser 2 Preferences:");
            user2.DisplayUserPreferences();

            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Assignment15: Implementing and Understanding Copy Constructor
            /*Person originalPerson = new Person("Fiyaz", "Kochi", 22);
            Console.WriteLine("\nOriginal Person Details:");
            originalPerson.DisplayDetails();

            Person personCopy = new Person(originalPerson);
            Console.WriteLine("\nCopied Person Details:");
            personCopy.DisplayDetails();

            Person referencedPerson = originalPerson;
            Console.WriteLine("\nReferenced Copy Person Details:");
            referencedPerson.DisplayDetails();

            referencedPerson.Name = "Ajai";
            referencedPerson.Address = "Calicut";
            referencedPerson.Age = 23;

            Console.WriteLine("\nOriginal Person Details after modification using reference copy:");
            originalPerson.DisplayDetails();

            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Assignment 16: Identifying the Need for Chained Constructors
            /*Cars car1 = new Cars("BMW");
            Console.WriteLine("Car 1 Details:");
            car1.DisplayCarDetails();

            Cars car2 = new Cars("Audi", "R8");
            Console.WriteLine("\nCar 2 Details:");
            car2.DisplayCarDetails();

            Cars car3 = new Cars("Ford", "Mustang", 2020);
            Console.WriteLine("\nCar 3 Details:");
            car3.DisplayCarDetails();

            Cars car4 = new Cars("Nissan", "Skyline", 2005, 279999.99);
            Console.WriteLine("\nCar 4 Details:");
            car4.DisplayCarDetails();

            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Assignment 17: Understanding the Need for Constructor Overloading
            /*Products product1 = new Products("Smart Phone");
            Console.WriteLine("Product 1 Details:");
            product1.DisplayProductDetails();

            Products product2 = new Products("Mouse", 50.00);
            Console.WriteLine("Product 2 Details:");
            product2.DisplayProductDetails();

            Products product3 = new Products("Keyboard", 100.00, 9);
            Console.WriteLine("Product 3 Details:");
            product3.DisplayProductDetails();

            Products product4 = new Products("Laptop", 200.00, 23);
            Console.WriteLine("Product 4 Details:");
            product4.DisplayProductDetails();

            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Assignment 18: Exploring Different Ways to Initialize Objects
            // 1. Constructor Initialization
            /*Product_s product1 = new Product_s("Laptop", 3200.00, "Electronics");
            Console.WriteLine("Constructor Initialization:");
            product1.DisplayProductDetails();

            // 2. Object Initializer Syntax
            Product_s product2 = new Product_s { Name = "Smartphone", Price = 1000.00, Category = "Electronics" };
            Console.WriteLine("\nObject Initializer Syntax:");
            product2.DisplayProductDetails();

            // 3. Static Factory Method
            Product_s product3 = Product_s.CreateProduct("Coffee Maker", 125.00, "Kitchen Appliances");
            Console.WriteLine("\nStatic Factory Method:");
            product3.DisplayProductDetails();

            // 4. Anonymous Types
            var product4 = new { Name = "Speaker", Price = 300.00, Category = "Electronics" };
            Console.WriteLine("\nAnonymous Type:");
            Console.WriteLine($"Name: {product4.Name}, Price: {product4.Price}, Category: {product4.Category}");

            // 5. Reflection
            Type productType = typeof(Product_s);
            Product_s product5 = (Product_s)Activator.CreateInstance(productType, "Micro Oven", 750.00, "Kitchen Appliances");
            Console.WriteLine("\nReflection:");
            product5.DisplayProductDetails();

            // 6. Default Values in Constructors
            Product_s product6 = new Product_s();
            Console.WriteLine("\nDefault Values in Constructors:");
            product6.DisplayProductDetails();

            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Assignment 19: Exploring Initialization Using Tuples and Records
            // //It's on another file ClassesAssignment(19).cs

            //----------------------------------------------------------------------------------------------------
            //Assignment 20: Shopping Cart
            /*ShoppingCart cart = new ShoppingCart();

            cart.AddProduct("Laptop", 5200.00, 5);
            cart.AddProduct("Smartphone", 800.00, 23);
            cart.AddProduct("Speakers", 150.00, 72);

            cart.DisplayCart();
            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Assignment 21: Banking System
            Banks bank = new Banks();

            // 1. Add Customers
            bank.AddCustomer("Fiyaz Nazeer");
            bank.AddCustomer("Ajai Bino");
            bank.AddCustomer("Cyril Kurian");
            Console.WriteLine();

            // 2. Add Accounts to Customers
            Banks.Customer customer1 = bank.FindCustomer("Fiyaz Nazeer");
            if (customer1 != null)
            {
                customer1.AddAccount("123456", 1500.00);
                customer1.AddAccount("246800", 3000.00);
            }

            Banks.Customer customer2 = bank.FindCustomer("Ajai Bino");
            if (customer2 != null)
            {
                customer2.AddAccount("135791", 2000.00);
            }

            // 3. Display Customer Account Details
            bank.DisplayCustomerDetails();
            Console.ReadLine();

            //----------------------------------------------------------------------------------------------------
            //Assignment 22: University System
            /*University university = new University();

            // 1. Add Departments
            university.AddDepartment("Computer Science");
            university.AddDepartment("Chemistry");
            university.AddDepartment("Mathematics");
            Console.WriteLine();*/

            // 2. Add Courses to Departments
            /*University.Department csDept = university.FindDepartment("Computer Science");
            if (csDept != null)
            {
                csDept.AddCourse("Introduction to C Programming", "CS101", 3);
                csDept.AddCourse("Data Structures", "CS102", 4);
            }
            University.Department chemistryDept = university.FindDepartment("Chemistry");
            if (chemistryDept != null)
            {
                chemistryDept.AddCourse("Organic Chemistry", "PHY101", 4);
            }
            University.Department mathDept = university.FindDepartment("Mathematics");
            if (mathDept != null)
            {
                mathDept.AddCourse("Calculus", "MATH101", 3);
                mathDept.AddCourse("Linear Algebra", "MATH102", 3);
            }
            // 3. Display Course Details
            university.DisplayCourseDetails();
            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
        }
    }
}