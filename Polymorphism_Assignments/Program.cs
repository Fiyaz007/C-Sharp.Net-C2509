using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# Assignment on Polymorphism
            //--------------------------------------------------------------------------------------------------------------
            //Assignment 1: To demonstrate Polymorphism and its Advantages
            /*Shape myShape;

            // Creating a Circle object
            myShape = new Circle();
            myShape.Draw();

            // Creating a Rectangle object
            myShape = new Rectangle();
            myShape.Draw();
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            //Assignment 2. Method Overloading and its uses
            /*Calculator calc = new Calculator();
            // Calling Multiply methods with different signatures
            Console.WriteLine("Multiplying two integers: 3 * 4 = " + calc.Multiply(3, 4)); 
            Console.WriteLine("Multiplying three integers: 9 * 3 * 2 = " + calc.Multiply(9, 3, 2)); 
            Console.WriteLine("Multiplying an integer and a double: 3 * 2.5 = " + calc.Multiply(3, 2.5));
            Console.WriteLine("Multiplying a double and an integer: 6.9 * 4 = " + calc.Multiply(6.9, 4));
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            //Assignment 3.Method Overriding
            /*Vehicle myVehicle = new Vehicle();
            myVehicle.Drive();

            // Base class reference to a derived class object
            myVehicle = new Car();
            myVehicle.Drive();

            // Directly using the derived class object
            Car myCar = new Car();
            myCar.Drive();
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            //Assignment 4. Scenario of Overriding 
            /*Payment payment1 = new CreditCardPayment();
            Payment payment2 = new PayPalPayment();

            // Process payments using different payment methods
            payment1.ProcessPayment(100.50);
            payment2.ProcessPayment(200.75);
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            //Assignment 5. Polymorphism with Static Data and Methods.
            /*Employee emp1 = new Manager();
            Employee emp2 = new Developer();
            Employee emp3 = new Developer();

            emp1.DisplayRole();
            emp2.DisplayRole();
            emp3.DisplayRole();

            // Displaying the total count of employees using the static method
            Employee.DisplayTotalEmployees();
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            //Assignment 6. Polymorphism with Arrays as Properties in a Class
            /*Employees[] employees = new Employees[]
            {
                new Managers(new string[] { "Budget Planning", "Team Meeting", "Project Review" }),
                new Developers(new string[] { "Code Review", "Implement Feature X", "Fix Bug #123" }),
                new Developers(new string[] { "Develop API", "Unit Testing", "Documentation Update" })
            };

            foreach (Employees emp in employees)
            {
                emp.DisplayRole();    
                emp.DisplayTasks();
                Console.WriteLine();
            }
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            //Assignment 7: Understanding Early Binding and Late Binding in C#
            // Early Binding (Method Overloading)
            /*Animal animal = new Animal();
            animal.Speak();
            animal.Speak("Woof Woof");

            // Late Binding (Method Overriding)
            Animal myDog = new Dog();
            Animal myBird = new Bird();

            myDog.Move();
            myBird.Move();
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            //Assignment 8. Achieving Runtime Polymorphism with Abstract Classes and Interfaces in C#
            // Array of IShape references (polymorphism using interface)
            /*IShape[] shapes = new IShape[]
            {
                new Circles(),
                new Rectangles()
            };
            // Using runtime polymorphism to call the appropriate Draw method
            foreach (IShape shape in shapes)
            {
                shape.Draw();
                // Demonstrating polymorphism with abstract class reference
                if (shape is Shapes s)
                {
                    s.GetDescription();
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            //Assignment 9. Demonstrating the Need for Multiple Inheritance of Interfaces
            /*Cars myCar = new Cars();

            // Calling methods from both interfaces
            myCar.Move();
            myCar.Draw();
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            //Assignment 10. Polymorphism in C# with Readonly Property
            Appliance[] appliances = new Appliance[]
            {
                new WashingMachine("LG"),
                new Refrigerator("Samsung")
            };

            foreach (Appliance appliance in appliances)
            {
                // Readonly property in use
                Console.WriteLine($"Appliance Brand: {appliance.Brand}");
                appliance.ShowFunction(); // Calls the correct overridden method
                Console.WriteLine();
            }
            Console.ReadLine();

            //--------------------------------------------------------------------------------------------------------------
        }
    }
}
