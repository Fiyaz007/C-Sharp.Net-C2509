using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignments
{
    //C# Assignments on Inheritance
    //----------------------------------------------------------------------------------------------------
    //Lab 1. Single Inheritance
    //Base Class
    public class Person
    {
        public string Name {  get; set; }
        public int Age { get; set; }
    }
    //Derived Class
    public class Student : Person
    {
        public string Grade {  get; set; }
        public Student(string name, int age, string grade) 
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"\nName: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Grade: {Grade}");
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Lab 2. Multilevel Inheritance
    // Base Class
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }
    // Derived Class from Animal
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }
    // Derived Class from Dog
    public class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Puppy is weeping.");
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Lab 3. Multiple Inheritance (via Interfaces)
    public interface IPrintable
    {
        void Print();
    }
    public interface IScannable
    {
        void Scan();
    }
    // Class implementing both interfaces
    public class PrinterScanner : IPrintable, IScannable
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }
        public void Scan()
        {
            Console.WriteLine("Scanning document...");
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Lab 4. Hierarchical Inheritance
    // Base Class
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }
    // Derived Class from Shape
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }
    // Derived Class from Shape
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Lab 5. Hybrid Inheritance (Using Interfaces)
    public interface IMovable
    {
        void Move();
    }
    public interface IRechargeable
    {
        void Recharge();
    }
    //Class Vehicle implementing Imovable
    public class Vehicle : IMovable
    {
        public virtual void Move()
        {
            Console.WriteLine("The vehicle is moving.");
        }
    }

    // Derived Class from Vehicle implementing IRechargeable
    public class ElectricCar : Vehicle, IRechargeable
    {
        public override void Move()
        {
            Console.WriteLine("The electric car is moving.");
        }
        public void Recharge()
        {
            Console.WriteLine("The electric car is recharging.");
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Lab 6. Overriding Methods in Inheritance
    // Base Class
    public class Employee
    {
        // Virtual method that can be overridden in derived classes
        public virtual void Work()
        {
            Console.WriteLine("Employee is working on tasks.");
        }
    }
    // Derived Class from Employee
    public class Manager : Employee
    {
        // Overriding the Work method
        public override void Work()
        {
            Console.WriteLine("Manager is managing projects.");
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Lab 7. Abstract Classes
    // Abstract Base Class
    public abstract class Vehicles
    {
        public abstract void Drive();
    }
    // Derived Class from Vehicle
    public class Car : Vehicles
    {
        // Implementing the abstract Drive method for Car
        public override void Drive()
        {
            Console.WriteLine("The car is driving on the highway.");
        }
    }
    // Derived Class from Vehicle
    public class Bike : Vehicles
    {
        // Implementing the abstract Drive method for Bike
        public override void Drive()
        {
            Console.WriteLine("The bike is racing though the city streets.");
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Lab 8. Sealed Classes
    // Sealed Class that cannot be inherited
    public sealed class MathOperations
    {
        // Method in the sealed class
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    // MathOperations is a sealed class and cannot be inherited.
    /*public class AdvancedMath : MathOperations
    {
        // This will not compile because MathOperations is sealed.
    }*/

    //----------------------------------------------------------------------------------------------------
    //Lab 9. Constructor Chaining
    // Base class
    public class Persons
    {
        public string Name {  get; set; }
        public Persons(string name)
        {
            Console.WriteLine("Person (Base Class) constructor called.");
            Name = name;
        }
    }
    // Derived Class from Person
    public class Employees : Persons
    {
        public Employees(string name) : base(name)
        {
            Console.WriteLine("Employee (Derived Class) constructor called.");
        }
        public void DisplayNameOfEmployee()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Lab 10.Interface Inheritance
    // Base Interface
    public interface IDriveable
    {
        void Drive();
    }
    // Derived Interface inheriting from IDriveable
    public interface IRaceable : IDriveable
    {
        void Race();
    }
    // Class implementing the IRaceable interface
    public class Bus : IRaceable
    {
        // Implementation of the Drive method from IDriveable
        public void Drive()
        {
            Console.WriteLine("The bus is driving.");
        }

        // Implementation of the Race method from IRaceable
        public void Race()
        {
            Console.WriteLine("The bus is racing!");
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Lab 11. IS-A Relationship (Inheritance)
    // Base Class
    public class Animals
    {
        public string Name { get; set; }
        public Animals(string name)
        {
            Name = name;
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }
    // Derived Class from Animal
    public class Dogs : Animals //Dog IS-A Animal
    {
        public Dogs(string name) : base(name)
        {
        }
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking!");
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Lab 12.HAS-A Relationship (Composition)
    // Class representing the Engine
    public class Engine
    {
        public int HorsePower { get; set; }
        public Engine(int horsePower)
        {
            HorsePower = horsePower;
        }
        public void DisplayEngineInfo()
        {
            Console.WriteLine($"Engine HorsePower: {HorsePower} HP");
        }
    }
    // Class representing the Car that HAS-A Engine
    public class Bikes
    {
        public Engine BikeEngine { get; set; } //Bike HAS-A Engine
        public string Brand { get; set; }
        public Bikes(string brand, Engine engine)
        {
            Brand = brand;
            BikeEngine = engine;
        }
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Bike Brand: {Brand}");
            BikeEngine.DisplayEngineInfo();
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Lab 13. Calling Base Class Method Using base
    // Base Class
    public class Person_s
    {
        // Method in the base class
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Displaying information for a person.");
        }
    }
    // Derived Class from Person
    public class Employee_s : Person_s
    {
        public override void DisplayInfo()
        {
            // Call the base class's DisplayInfo method
            base.DisplayInfo();
            Console.WriteLine("Displaying additional information for an employee.");
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Lab 14. Accessing Base Class Variable Using base
    // Base Class
    public class Person_
    {
        public string Name { get; set; }
    }
    // Derived Class from Person
    public class Students : Person_
    {
        // Hiding the Name property
        public new string Name { get; set; }
        // Method to display both base class and derived class Name properties
        public void DisplayNames()
        {
            Console.WriteLine("Base class Name: " + base.Name);
            Console.WriteLine("Derived class Name: " + Name);
        }
    }

    //----------------------------------------------------------------------------------------------------
    //Lab 15.Calling Base Class Constructor Using base
    // Base Class
    public class Vehicle_s
    {
        public string Brand { get; set; }
        public Vehicle_s(string brand)
        {
            Brand = brand;
            Console.WriteLine($"Vehicle constructor called. Brand: {Brand}");
        }
    }
    // Derived Class from Vehicle
    public class Cars : Vehicle_s
    {
        public string Model { get; set; }

        // Constructor in the derived class that uses 'base' to call the Vehicle constructor
        public Cars(string brand, string model) : base(brand)
        {
            Model = model;
            Console.WriteLine($"Car constructor called. Model: {Model}");
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Car Information: Brand = {Brand}, Model = {Model}");
        }
    }

    //----------------------------------------------------------------------------------------------------
}
