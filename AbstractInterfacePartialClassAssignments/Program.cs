using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfacePartialClassAssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# Assignments on Abstract Class, Interface and Partial Class
            //--------------------------------------------------------------------------------------------------------------------------------------------
            //Assignment 1. Abstract Class
            /*Vehicle car = new Car();
            Vehicle motorcycle = new Motorcycle();

            car.StartEngine();
            car.StopEngine();

            motorcycle.StartEngine();
            motorcycle.StopEngine();
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------------------------------------
            //Assignment 2. Virtual Functions
            /*Animal dog = new Dog();
            Animal cat = new Cat();

            dog.MakeSound();
            cat.MakeSound();
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------------------------------------
            //Assignment 3. Interface
            /*Cars myCar = new Cars();
            Truck myTruck = new Truck();

            myCar.Drive();
            myTruck.Drive();
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------------------------------------
            //Assignment 4.Interface vs.Abstract Class
            /*Eagle myEagle = new Eagle();

            myEagle.Fly();
            myEagle.Swim();
            myEagle.MakeSound();
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------------------------------------
            //Assignment 5. Static Class
            // Calling static methods directly using the class name
            /*int sum = MathOperations.Add(25, 64);
            int product = MathOperations.Multiply(57, 21);

            Console.WriteLine($"The Sum  = {sum}");
            Console.WriteLine($"The Product  = {product}");
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------------------------------------
            //Assignment 6. Extension Methods
            /*int number1 = 14;
            int number2 = 47;

            Console.WriteLine($"{number1} is Even: {number1.IsEven()}");
            Console.WriteLine($"{number2} is Even: {number2.IsEven()}");
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------------------------------------
            //Assignment 7. Partial Class
            /*Person person = new Person();
            person.Name = "Fiyaz Nazeer";

            person.ShowDetails();
            Console.ReadLine() ;*/

            //--------------------------------------------------------------------------------------------------------------------------------------------
            //Assignment 8. Partial Methods
            /*Employee employee = new Employee
            {
                name = "John Doe",
                ratePerHour = 22.50,
                hours = 47
            };

            employee.DisplaySalary();
            Console.ReadLine() ;*/

            //--------------------------------------------------------------------------------------------------------------------------------------------
            //Assignment 9. Indexer
            /*Library library = new Library();
            library[0] = "Wings of Fire";
            library[1] = "The Murder on the Orient Express";
            library[2] = "Forty Rules Of Love";

            library.DisplayBooks();
            Console.ReadLine() ;*/

            //--------------------------------------------------------------------------------------------------------------------------------------------
            //Assignment 10. Exception Handling 
            /*Calculate math = new Calculate();

            double result1 = math.Divide(18, 4);     //Valid division
            Console.WriteLine("Result: " + result1);
            Console.WriteLine();

            double result2 = math.Divide(10, 0);     //Division by Zero
            Console.WriteLine("Result: " + result2);
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------------------------------------
            //Assignment 11. Enum
            /*Car_s sedanCar = new Car_s(CarType.Sedan);
            Car_s suvCar = new Car_s(CarType.SUV);
            Car_s truckCar = new Car_s(CarType.Truck);
            Car_s coupeCar = new Car_s(CarType.Coupe);

            sedanCar.DisplayCarTypeMessage();
            suvCar.DisplayCarTypeMessage();
            truckCar.DisplayCarTypeMessage();
            coupeCar.DisplayCarTypeMessage();
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------------------------------------
            //Assignment 12. Attributes
            // Retrieve Class Attribute
            /*Type calculatorType = typeof(Calculator);
            var classAttributes = calculatorType.GetCustomAttributes(false);
            foreach (DeveloperAttribute attr in classAttributes)
            {
                Console.WriteLine($"Class Develped by: {attr.Name}, Last Modified: {attr.LastModified}\n");
            }

            // Retrieve Method Attribute
            var methodInfo = calculatorType.GetMethod("Add");
            var methodAttributes = methodInfo.GetCustomAttributes(false);
            foreach (DeveloperAttribute attr in methodAttributes)
            {
                Console.WriteLine($"Method Develped by: {attr.Name}, Last Modified: {attr.LastModified}");
            }
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
