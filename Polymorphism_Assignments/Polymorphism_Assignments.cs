using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignments
{
    //C# Assignment on Polymorphism
    //--------------------------------------------------------------------------------------------------------------
    //Assignment 1: To demonstrate Polymorphism and its Advantages
    // Base class
    class Shape
    {
        // Virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }
    // Derived class: Circle
    class Circle : Shape
    {
        // Override the Draw method for Circle
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }
    }
    // Derived class: Rectangle
    class Rectangle : Shape
    {
        // Override the Draw method for Rectangle
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle.");
        }
    }

    //--------------------------------------------------------------------------------------------------------------
    //Assignment 2. Method Overloading and its uses
    class Calculator
    {
        // Multiply two integers
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        // Multiply three integers
        public int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
        // Multiply an integer and a double
        public double Multiply(int a, double b)
        {
            return a * b;
        }
        // Multiply a double and an integer
        public double Multiply(double a, int b)
        {
            return a * b;
        }
    }

    //--------------------------------------------------------------------------------------------------------------
    //Assignment 3. Method Overriding
    // Base class
    class Vehicle
    {
        // Virtual method
        public virtual void Drive()
        {
            Console.WriteLine("Driving a vehicle.");
        }
    }
    // Derived class: Car
    class Car : Vehicle
    {
        // Override the Drive method for Car
        public override void Drive()
        {
            Console.WriteLine("Driving a car.");
        }
    }

    //--------------------------------------------------------------------------------------------------------------
    //Assignment 4. Scenario of Overriding 
    // Base class
    class Payment
    {
        // Virtual method
        public virtual void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing a generic payment of $" + amount);
        }
    }
    // Derived class CreditCardPayment
    class CreditCardPayment : Payment
    {
        // Override ProcessPayment for credit card payments
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing credit card payment of $" + amount);
        }
    }
    // Derived class: PayPalPayment
    class PayPalPayment : Payment
    {
        // Override ProcessPayment for PayPal payments
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing PayPal payment of $" + amount);
        }
    }

    //--------------------------------------------------------------------------------------------------------------
    //Assignment 5. Polymorphism with Static Data and Methods.
    // Base class
    class Employee
    {
        protected static int employeeCount = 0;
        public Employee()
        {
            employeeCount++;
        }
        // Virtual method
        public virtual void DisplayRole()
        {
            Console.WriteLine("I am an employee.");
        }
        // Static method to display the total count of employees
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine($"Total number of employees: {employeeCount}");
        }
    }
    // Derived class Manager
    class Manager : Employee
    {
        // Override the DisplayRole method for Manager
        public override void DisplayRole()
        {
            Console.WriteLine("I am a Manager.");
        }
    }
    // Derived class Developer
    class Developer : Employee
    {
        // Override the DisplayRole method for Developer
        public override void DisplayRole()
        {
            Console.WriteLine("I am a Developer.");
        }
    }

    //--------------------------------------------------------------------------------------------------------------
    //Assignment 6. Polymorphism with Arrays as Properties in a Class
    // Base class
    class Employees
    {
        public string[] Tasks { get; set; }
        public Employees(string[] tasks)
        {
            Tasks = tasks;
        }
        // Virtual method
        public virtual void DisplayRole()
        {
            Console.WriteLine("I am an employee.");
        }
        public void DisplayTasks()
        {
            Console.WriteLine("Tasks assigned:");
            foreach (string task in Tasks)
            {
                Console.WriteLine($"- {task}");
            }
        }
    }
    // Derived class Manager
    class Managers : Employees
    {
        // Constructor that calls the base constructor
        public Managers(string[] tasks) : base(tasks) { }

        // Override the DisplayRole method for Manager
        public override void DisplayRole()
        {
            Console.WriteLine("I am a Manager.");
        }
    }
    // Derived class Developer
    class Developers : Employees
    {
        // Constructor that calls the base constructor
        public Developers(string[] tasks) : base(tasks) { }

        // Override the DisplayRole method for Developer
        public override void DisplayRole()
        {
            Console.WriteLine("I am a Developer.");
        }
    }

    //--------------------------------------------------------------------------------------------------------------
    //Assignment 7: Understanding Early Binding and Late Binding in C#
    // Base class
    class Animal
    {
        // Early Binding - Method Overloading
        public void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
        public void Speak(string sound)
        {
            Console.WriteLine("The animal says: " + sound);
        }
        // Late Binding - Method Overriding
        public virtual void Move()
        {
            Console.WriteLine("The animal moves.");
        }
    }
    // Derived class Dog
    class Dog : Animal
    {
        // Overriding the Move method for Dog (Late Binding)
        public override void Move()
        {
            Console.WriteLine("The dog runs.");
        }
    }
    // Derived class Bird
    class Bird : Animal
    {
        // Overriding the Move method for Bird (Late Binding)
        public override void Move()
        {
            Console.WriteLine("The bird flies.");
        }
    }

    //--------------------------------------------------------------------------------------------------------------
    //Assignment 8. Achieving Runtime Polymorphism with Abstract Classes and Interfaces in C#
    // Interface for shapes
    interface IShape
    {
        void Draw();
    }
    // Abstract class
    abstract class Shapes : IShape
    {
        // Abstract method to be implemented by derived classes
        public abstract void Draw();

        // Virtual method that can be overridden
        public virtual void GetDescription()
        {
            Console.WriteLine("This is a shape.");
        }
    }
    // Derived class: Circle
    class Circles : Shapes
    {
        // Implementing the abstract Draw method
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }

        // Overriding the GetDescription method
        public override void GetDescription()
        {
            Console.WriteLine("This is a Circle.");
        }
    }
    // Derived class Rectangle
    class Rectangles : Shapes
    {
        // Implementing the abstract Draw method
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle.");
        }
        // Overriding the GetDescription method
        public override void GetDescription()
        {
            Console.WriteLine("This is a Rectangle.");
        }
    }

    //--------------------------------------------------------------------------------------------------------------
    //Assignment 9. Demonstrating the Need for Multiple Inheritance of Interfaces
    // Define the IMovable interface
    interface IMovable
    {
        void Move(); // Method for moving the object
    }
    // Define the IDrawable interface
    interface IDrawable
    {
        void Draw(); // Method for drawing the object
    }
    // Car class implementing both IMovable and IDrawable interfaces
    class Cars : IMovable, IDrawable
    {
        public void Move()
        {
            Console.WriteLine("The car is moving.");
        }
        public void Draw()
        {
            Console.WriteLine("Drawing the car.");
        }
    }

    //--------------------------------------------------------------------------------------------------------------
    //Assignment 10. Polymorphism in C# with Readonly Property
    // Base class
    abstract class Appliance
    {
        // Readonly property for appliance brand
        public readonly string Brand;

        // Constructor to initialize the readonly property
        protected Appliance(string brand)
        {
            Brand = brand;
        }
        // Abstract method to be implemented by derived classes
        public abstract void ShowFunction();
    }
    // Derived class WashingMachine
    class WashingMachine : Appliance
    {
        public WashingMachine(string brand) : base(brand) { }
        public override void ShowFunction()
        {
            Console.WriteLine($"{Brand} Washing Machine is used to wash clothes.");
        }
    }
    // Derived class Refrigerator
    class Refrigerator : Appliance
    {
        public Refrigerator(string brand) : base(brand) { }
        public override void ShowFunction()
        {
            Console.WriteLine($"{Brand} Refrigerator is used to keep food cool.");
        }
    }

    //--------------------------------------------------------------------------------------------------------------
}
