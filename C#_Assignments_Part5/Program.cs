using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignments_Part5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Assignments & Solutions: Part 5
            // ------------------------------------------------------------------------------------------------------------------------------
            // Assignment 1.Identify the need for single and multidimensional arrays as properties of a class
            /*Library library = new Library(3);
            library.AddBook("The Murder On The Orient Express");
            library.AddBook("40 Rules of Love");
            library.DisplayBooks();
            Console.WriteLine();

            Classroom classroom = new Classroom(3, 4);
            classroom.AssignSeat(0, 0, "Fiyaz");
            classroom.AssignSeat(1, 3, "Ajai");
            classroom.AssignSeat(2, 1, "Cyril");
            classroom.DisplaySeating();
            Console.ReadLine();*/

            // ------------------------------------------------------------------------------------------------------------------------------
            // Assignment 2. Identify the need for an array of objects
            /*MovieLibrary library = new MovieLibrary(5);

            // Create and add movies to the library
            library.AddMovie(new Movie("Inception", 2010));
            library.AddMovie(new Movie("The Avengers", 2012));
            library.AddMovie(new Movie("DeadPool and Wolverine", 2024));

            library.DisplayMovies();
            Console.ReadLine();*/

            // ------------------------------------------------------------------------------------------------------------------------------
            // Assignment 3. Identify the need for enumerations
            /*Order order1 = new Order(115, OrderStatus.Pending);
            order1.DisplayOrderInfo();

            order1.UpdateStatus(OrderStatus.Shipped);            // Update the status to Shipped
            order1.DisplayOrderInfo();

            order1.UpdateStatus(OrderStatus.Delivered);          // Update the status to Delivered
            order1.DisplayOrderInfo();
            Console.ReadLine();*/

            // ------------------------------------------------------------------------------------------------------------------------------
            // Assignment 4. Identify the need for value types and reference types
            /*Circle circle1 = new Circle(7.0);
            Circle circle2 = circle1;       // This creates a copy of circle1

            Console.WriteLine("Initial Values:");
            Console.WriteLine($"Circle 1 Radius:{circle1.Radius}");
            Console.WriteLine($"Circle 2 Radius:{circle2.Radius}");

            circle2.Radius = 14.3;

            Console.WriteLine("\nAfter Modifying circle2:");
            Console.WriteLine($"Circle 1 Radius:{circle1.Radius}");
            Console.WriteLine($"Circle 2 Radius:{circle2.Radius}");

            Shape shape1 = new Shape(7.0);
            Shape shape2 = shape1;          // This creates a reference to shape1

            Console.WriteLine("\nInitial Values:");
            Console.WriteLine($"Shape 1 Radius:{shape1.Radius}");
            Console.WriteLine($"Shape 2 Radius:{shape2.Radius}");

            shape2.Radius = 14.3;

            Console.WriteLine("\nAfter Modifying shape2:");
            Console.WriteLine($"Shape 1 Radius:{shape1.Radius}");
            Console.WriteLine($"Shape 2 Radius:{shape2.Radius}");

            Console.ReadLine();*/

            // ------------------------------------------------------------------------------------------------------------------------------
            // Assignment 5. Identify the need for pass by reference using ref keyword
            /*Game game = new Game();

            int playerScore = 40;
            Console.WriteLine($"Initial Score: {playerScore}");

            game.IncreaseScore(ref playerScore);            // Pass playerScore by reference to IncreaseScore method

            Console.WriteLine($"Score after Increasing: {playerScore}");
            Console.ReadLine();*/

            // ------------------------------------------------------------------------------------------------------------------------------
            // Assignment 6. Identify the need for out parameters
            /*Calculator calculator = new Calculator();

            int numerator = 23;
            int denominator = 3;
            calculator.Divide(numerator, denominator, out int quotient, out int remainder);

            Console.WriteLine($"Qoutient : {quotient}");
            Console.WriteLine($"Remainder : {remainder}");

            Console.ReadLine();*/

            // ------------------------------------------------------------------------------------------------------------------------------
            // Assignment 7. What is Exception and its Types
            /*try
            {
                // Demonstrating FileNotFoundException
                StreamReader reader = new StreamReader("Non-existFile.txt");
                Console.WriteLine(reader.ReadToEnd());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"FileNotFoundException Caught! \nMessage: {ex.Message}");
            }
            try
            {
                // Demonstrating IndexOutOfRangeException
                int[] array = { 1, 2, 3, 4 };
                Console.WriteLine(array[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"\nIndexOutOfRangeException Caught! \nMessage: {ex.Message}");
            }
            Console.ReadLine();*/

            // ------------------------------------------------------------------------------------------------------------------------------
            // Assignment 8. How to Handle Exception
            /*int userInput = IntegerCheck.GetUserInput();
            Console.WriteLine($"You entered a valid integer: {userInput}");

            Console.ReadLine();*/

            // ------------------------------------------------------------------------------------------------------------------------------
            // Assignment 9.Multiple Catch Blocks
            /*Calculate.CalculateDivision();
            Console.ReadLine();*/

            // ------------------------------------------------------------------------------------------------------------------------------
            // Assignment 10. Finally Block
            /*Final.ReadFile("D:\\Quest Training\\C#_Assignments_Part5\\example.txt");
            Console.ReadLine();*/

            // ------------------------------------------------------------------------------------------------------------------------------
            // Assignment 11. Difference between throw and throws
            /*try
            {
                Console.Write("Enter an age: ");
                int age = int.Parse(Console.ReadLine());
                Age.ValidateAge(age);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("-------THE END-------");
            }
            Console.ReadLine();*/

            // ------------------------------------------------------------------------------------------------------------------------------
            // Assignment 12. Custom Exception
            /*try
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                Negative.CheckNumber(number);
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine($"Custom Exception caught: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("-------THE END-------");
            }
            Console.ReadLine();*/

            // ------------------------------------------------------------------------------------------------------------------------------
            // Assignment 13.Logging Exceptions
            /*int numerator = 17;
            int denominator = 0;
            try
            {
                int result = numerator / denominator;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Logger.LogError("Attempted to divide by zero.", ex);
                Console.WriteLine("DivideByZeroException caught and logged.");
            }
            finally
            {
                Console.WriteLine("-------THE END-------");
            }
            Console.ReadLine();*/

            // ------------------------------------------------------------------------------------------------------------------------------
            // Assignment 14. Identify the Need for User-Defined Exceptions, Create Them, and Throw Them
            /*try
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                CheckNumber.ProcessPositiveNumber(number);
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine($"Custom Exception Caught: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("-------THE END-------");
            }
            Console.ReadLine();*/

            // ------------------------------------------------------------------------------------------------------------------------------
            // Assignment 15. Explain the Difference between Exception (Checked Exceptions) and RuntimeException(Unchecked Exceptions)
            // Task 4: Test Class:
            FileProcessor fileProcessor = new FileProcessor();
            fileProcessor.ReadFileContent("nonexistent.txt");
            Console.WriteLine("--------------------------------------------------------");

            //-------------------------------------------------------------------
            MathOperations mathOperations = new MathOperations();

            Console.WriteLine("Result of 25 / 5: " + mathOperations.Divide(25, 5));
            Console.WriteLine("Result of 23 / 0: " + mathOperations.Divide(23, 0));
            Console.WriteLine("--------------------------------------------------------");

            //-------------------------------------------------------------------
            Person person = new Person();
            try
            {
                Console.Write("Enter the age of the Person: ");
                int age = int.Parse(Console.ReadLine());
                person.SetAge(age);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("--------------------------------------------------------");
            }

            Console.ReadLine();

            // ------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
