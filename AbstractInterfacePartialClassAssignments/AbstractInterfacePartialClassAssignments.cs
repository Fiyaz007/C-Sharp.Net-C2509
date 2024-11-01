using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfacePartialClassAssignments
{
    //C# Assignments on Abstract Class, Interface and Partial Class
    //--------------------------------------------------------------------------------------------------------------------------------------------
    //Assignment 1. Abstract Class
    public abstract class Vehicle
    {
        public abstract void StartEngine(); //Abstract Method
        public void StopEngine()            //Concrete Method
        {
            Console.WriteLine("Engine Stopped...");
        }
    }
    public class Car : Vehicle
    {
        public override void StartEngine()  //overriding abstract method
        {
            Console.WriteLine("Car Engine is Started, ready to Drive...");
        }
    }
    public class Motorcycle : Vehicle
    {
        public override void StartEngine()  //overriding abstract method
        {
            Console.WriteLine("\nMotorcycle Engine is Started, ready to Ride...");
        }
    }

    //--------------------------------------------------------------------------------------------------------------------------------------------
    //Assignment 2. Virtual Functions
    public class Animal
    {
        public virtual void MakeSound()   //virtual method
        {
            Console.WriteLine("The Animal makes a sound");
        }
    }
    public class Dog : Animal
    {
        public override void MakeSound()   //overrides virtual method
        {
            Console.WriteLine("The Dog barks WOOF!!");
        }
    }
    public class Cat : Animal
    {
        public override void MakeSound()   //overrides virtual method
        {
            Console.WriteLine("The Cat says MEOW!!");
        }
    }

    //--------------------------------------------------------------------------------------------------------------------------------------------
    //Assignment 3. Interface
    interface IDrive         //Interface
    {
        void Drive();
    }
    public class  Cars : IDrive     //Class Cars implements IDrive
    {
        public void Drive()
        {
            Console.WriteLine("The car is driving smoothly on the road...");
        }
    }
    public class Truck : IDrive     //Class Truck implements IDrive  
    {
        public void Drive()
        {
            Console.WriteLine("The Truck is driving roughly on the terrain...");
        }
    }

    //--------------------------------------------------------------------------------------------------------------------------------------------
    //Assignment 4.Interface vs.Abstract Class
    public abstract class Bird     //Abtract Class
    {
        public abstract void Fly();     //Abtract Method
        public void MakeSound()     //Concrete Method
        {
            Console.WriteLine("The birds make sound...");
        }
    }
    interface ISwim     //Interface ISwim
    {
        void Swim();
    }
    public class Eagle: Bird, ISwim
    {
        public override void Fly()     //Overrides Abstract Method
        {
            Console.WriteLine("Eagle is flying high in the sky...");
        }
        public void Swim()     //Implementing Interface
        {
            Console.WriteLine("Eagle can't swim in water");
        }
    }

    //--------------------------------------------------------------------------------------------------------------------------------------------
    //Assignment 5. Static Class
    public static class MathOperations     //Static Class
    {
        public static int Add(int number1, int number2)     //Static Method
        {
            return number1 + number2;
        }
        public static int Multiply(int number1, int number2)     //Static Method
        {
            return number1 * number2;
        }
    }

    //--------------------------------------------------------------------------------------------------------------------------------------------
    //Assignment 6. Extension Methods
    public static class IntExtensions
    {
        public static bool IsEven(this int number)     // Extension method for int type
        {
            return number % 2 == 0;
        }
    }

    //--------------------------------------------------------------------------------------------------------------------------------------------
    //Assignment 7. Partial Class
    public partial class Person     //Partial class Person with property Name
    {
        public string Name { get; set; }
    }

    //--------------------------------------------------------------------------------------------------------------------------------------------
    //Assignment 8. Partial Methods
    public partial class Employee
    {
        public string name;
        public double ratePerHour;
        public int hours;

        partial void CalculateSalary();     // Declaration of the partial method
    }

    //--------------------------------------------------------------------------------------------------------------------------------------------
    //Assignment 9. Indexer
    public class Library
    {
        public string[] Books = new string[3];
        public string this[int index]
        {
            get { return Books[index]; }
            set { Books[index] = value; }
        }
        public void DisplayBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine($"--{book}");
            }
        }
    }

    //--------------------------------------------------------------------------------------------------------------------------------------------
    //Assignment 10. Exception Handling 
    public class Calculate
    {
        public double Divide(int numerator, int denominator)     // Method to perform division with exception handling
        {
            try
            {
                return numerator / denominator;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
            finally
            {
                Console.WriteLine("Division operation Completed.");
            }
        }
    }

    //--------------------------------------------------------------------------------------------------------------------------------------------
    //Assignment 11. Enum
    public enum CarType
    {
        Sedan,
        SUV,
        Truck,
        Coupe
    }
    public class Car_s
    {
        public CarType Type { get; set; }
        public Car_s(CarType type)
        {
            Type = type;
        }
        public void DisplayCarTypeMessage()     // Method to display a message specific to the CarType
        {
            switch (Type)
            {
                case CarType.Sedan:
                    Console.WriteLine("\nThis is a Sedan, known for its comfort and fuel efficiency.");
                    break;
                case CarType.SUV:
                    Console.WriteLine("\nThis is an SUV, ideal for families and off-road driving.");
                    break;
                case CarType.Truck:
                    Console.WriteLine("\nThis is a Truck, suitable for heavy work and cargo.");
                    break;
                case CarType.Coupe:
                    Console.WriteLine("\nThis is a Coupe, a sporty and compact car.");
                    break;
                default:
                    Console.WriteLine("Unknown car type.");
                    break;
            }
        }
    }

    //--------------------------------------------------------------------------------------------------------------------------------------------
    //Assignment 12. Attributes
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class DeveloperAttribute : Attribute
    {
        public string Name { get; }
        public string LastModified { get; }

        public DeveloperAttribute(string name, string lastModified)
        {
            Name = name;
            LastModified = lastModified;
        }
    }
    [Developer("Fiyaz Nazeer", "2024-10-26")]
    public class Calculator
    {
        [Developer("Ajai Bino", "2024-10-29")]
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
    }

    //--------------------------------------------------------------------------------------------------------------------------------------------
}
