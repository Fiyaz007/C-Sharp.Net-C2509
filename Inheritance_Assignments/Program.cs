using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# Assignments on Inheritance
            //----------------------------------------------------------------------------------------------------
            //Lab 1. Single Inheritance
            /*Student student1 = new Student("Fiyaz", 22, "A");
            Student student2 = new Student("Ajai", 21, "B");

            //Displaying Student Details
            student1.DisplayStudentInfo();
            student2.DisplayStudentInfo();
            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Lab 2. Multilevel Inheritance
            /*Puppy puppy = new Puppy();

            puppy.Eat();  // Method from the base class Animal
            puppy.Bark(); // Method from the derived class Dog
            puppy.Weep(); // Method from the Puppy class
            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Lab 3. Multiple Inheritance (via Interfaces)
            /*PrinterScanner printerScanner = new PrinterScanner();

            //multiple inheritance via interfaces
            printerScanner.Print();
            printerScanner.Scan();
            Console.ReadLine();
*/
            //----------------------------------------------------------------------------------------------------
            //Lab 4. Hierarchical Inheritance
            /*Shape circle = new Circle();
            Shape rectangle = new Rectangle();

            //Hierarchical Inheritance
            circle.Draw();
            rectangle.Draw();
            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Lab 5. Hybrid Inheritance (Using Interfaces)
            /*ElectricCar myElectricCar = new ElectricCar();

            Console.WriteLine("Electric Car Behavior:");
            myElectricCar.Move();
            myElectricCar.Recharge();

            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Lab 6. Overriding Methods in Inheritance
            // Creating an object of the base class Employee
            /*Employee employee = new Employee();
            employee.Work();  // Calls the Work method in Employee

            // Creating an object of the derived class Manager
            Manager manager = new Manager();
            manager.Work();  // Calls the overridden Work method in Manager
            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Lab 7. Abstract Classes
            /*Vehicles myCar = new Car();
            Vehicles myBike = new Bike();

            // Abstract class inheritance and method implementation
            Console.WriteLine("Vehicle Behavior:");
            myCar.Drive();
            myBike.Drive();
            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Lab 8. Sealed Classes
            /*MathOperations math = new MathOperations();
            int result = math.Add(10, 20);

            Console.WriteLine("Result of addition: " + result);
            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Lab 9. Constructor Chaining
            // Creating an object of the derived class Employee
            /*Employees employee = new Employees("Fiyaz Nazeer");

            employee.DisplayNameOfEmployee();
            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Lab 10.Interface Inheritance
            /*Bus myBus = new Bus();

            // Interface inheritance
            myBus.Drive();
            myBus.Race();
            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Lab 11. IS-A Relationship (Inheritance)
            /*Dogs myDog = new Dogs("Jack");

            // Demonstrating the IS-A relationship
            Console.WriteLine("Demonstrating IS-A Relationship:");
            myDog.Eat();
            myDog.Bark();
            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Lab 12.HAS-A Relationship (Composition)
            /*Engine myEngine = new Engine(300);

            // Creating a Bike object that has an Engine
            Bikes myBike = new Bikes("Yamaha", myEngine);

            Console.WriteLine("Bike and Engine Details:");
            myBike.DisplayCarInfo();
            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Lab 13. Calling Base Class Method Using base
            /*Employee_s employee = new Employee_s();

            // Calling the overridden DisplayInfo method
            employee.DisplayInfo();
            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Lab 14. Accessing Base Class Variable Using base
            /*Students student = new Students();

            student.Name = "Fiyaz (Derived)";
            ((Person_)student).Name = "Fiyaz (Base)";

            // Displaying both names
            student.DisplayNames();
            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
            //Lab 15.Calling Base Class Constructor Using base
            /*Cars myCar = new Cars("Ford", "Mustang");

            Console.WriteLine("Car Details:");
            myCar.DisplayInfo();
            Console.ReadLine();*/

            //----------------------------------------------------------------------------------------------------
        }
    }
}
