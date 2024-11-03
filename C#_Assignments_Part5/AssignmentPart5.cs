using log4net.Config;
using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignments_Part5
{
    // C# Assignments & Solutions: Part 5
    // ------------------------------------------------------------------------------------------------------------------------------
    // Assignment 1.Identify the need for single and multidimensional arrays as properties of a class
    class Library     // Library Class using a Single-Dimensional Array
    {
        private string[] books;
        private int bookCount;
        public Library(int size)
        {
            books = new string[size];
            bookCount = 0;
        }
        public void AddBook(string bookTitle)     //Mathod to Add books to Library
        {
            if (bookCount < books.Length)
            {
                books[bookCount] = bookTitle;
                bookCount++;
                Console.WriteLine($"Book '{bookTitle}' added to the library.");
            }
            else
            {
                Console.WriteLine("Library is full. Cannot add more books.");
            }
        }
        public void DisplayBooks()     //Mathod to Display books in the Library
        {
            Console.WriteLine("\nBooks in the library:");
            for (int i = 0; i < bookCount; i++)
            {
                Console.WriteLine($"- {books[i]}");
            }
        }
    }
    class Classroom     // Classroom Class using a Two-Dimensional Array
    {
        private string[,] seats;
        public Classroom(int rows, int columns)
        {
            seats = new string[rows, columns];
        }
        public void AssignSeat(int row, int column, string studentName)     //Method to Assign seats to students
        {
            if (row < seats.GetLength(0) && column < seats.GetLength(1))
            {
                seats[row, column] = studentName;
                Console.WriteLine($"Seat assigned to {studentName} at {row} row {column} column.");
            }
            else
            {
                Console.WriteLine("Invalid seat position.");
            }
        }
        public void DisplaySeating()     //Mathod to display seating
        {
            Console.WriteLine("\nClassroom seating arrangement:");
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    string seat = seats[i, j] ?? "Empty";
                    Console.Write($"{seat}\t");
                }
                Console.WriteLine();
            }
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------------
    // Assignment 2. Identify the need for an array of objects
    // Movie Class to represent individual movies
    class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public Movie(string title, int year)
        {
            Title = title;
            Year = year;
        }
        public void DisplayInfo()        // Method to display movie information
        {
            Console.WriteLine($"Title: {Title}, Year: {Year}");
        }
    }
    class MovieLibrary    // MovieLibrary Class to store array of Movie objects
    {
        private Movie[] movies;
        private int movieCount;
        public MovieLibrary(int size)
        {
            movies = new Movie[size];
            movieCount = 0;
        }
        public void AddMovie(Movie movie)        // Method to add a movie to the library
        {
            if (movieCount < movies.Length)
            {
                movies[movieCount] = movie;
                movieCount++;
                Console.WriteLine($"Movie '{movie.Title}' added to the library.");
            }
            else
            {
                Console.WriteLine("Movie library is full. Cannot add more movies.");
            }
        }
        public void DisplayMovies()        // Method to display all movies in the library
        {
            Console.WriteLine("\nMovies in the library:");
            for (int i = 0; i < movieCount; i++)
            {
                movies[i].DisplayInfo();
            }
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------------
    // Assignment 3. Identify the need for enumerations
    enum OrderStatus    // Enumeration for Order Status
    {
        Pending,
        Shipped,
        Delivered
    }
    class Order    // Order Class to manage order details
    {
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }
        public Order(int orderId, OrderStatus status)
        {
            OrderId = orderId;
            Status = status;
        }
        public void DisplayOrderInfo()        // Method to display order information
        {
            Console.WriteLine($"Order ID: {OrderId}, Status: {Status}");
        }
        public void UpdateStatus(OrderStatus newStatus)        // Method to update order status
        {
            Status = newStatus;
            Console.WriteLine($"\nOrder ID: {OrderId} status updated to {Status}.");
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------------
    // Assignment 4. Identify the need for value types and reference types
    public struct Circle          //Value Type
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
    public class Shape
    {
        public double Radius { get; set; }
        public Shape(double radius)
        {
            Radius = radius;
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------------
    // Assignment 5. Identify the need for pass by reference using ref keyword
    class Game
    {
        public void IncreaseScore(ref int score)        // Method to increase score by 10, using ref parameter
        {
            score += 10;
            Console.WriteLine($"Score increased by 10.");
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------------
    // Assignment 6. Identify the need for out parameters
    public class Calculator
    {
        public void Divide(int numerator, int denominator, out int quotient,  out int remainder)
        {
            quotient = numerator / denominator;
            remainder = numerator % denominator;
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------------
    // Assignment 7. What is Exception and its Types
    // Implemented in program.cs

    // ------------------------------------------------------------------------------------------------------------------------------
    // Assignment 8. How to Handle Exception
    public static class IntegerCheck
    {
        public static int GetUserInput()
        {
            int input;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter an Integer: ");
                    input = int.Parse(Console.ReadLine());              // Attempt to parse user input as an integer
                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid input!, please enter a valid integer");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Input is too large. Please enter a valid integer.");
                }
            }
            return input;
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------------
    // Assignment 9.Multiple Catch Blocks
    public static class Calculate
    {
        public static void CalculateDivision()        // Method to perform division and handle exceptions
        {
            try
            {
                Console.Write("Enter the first integer (numerator): ");
                int numerator = int.Parse(Console.ReadLine());

                Console.Write("Enter the second integer (denominator): ");
                int denominator = int.Parse(Console.ReadLine());

                int result = numerator / denominator;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero. Please enter a non-zero denominator.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
            }
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------------
    // Assignment 10. Finally Block
    public static class Final
    {
        public static void ReadFile(string fileName)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(fileName);
                string content = reader.ReadToEnd();
                Console.WriteLine($"File Content: {content}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: The file was not found.");
            }
            finally
            {
                if (reader != null)                // Ensure the file is closed, even if an exception occurred
                {
                    reader.Close();
                    Console.WriteLine("File has been closed.");
                }
            }
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------------
    // Assignment 11. Difference between throw and throws
    public class Age
    {
        public static void ValidateAge(int age)          // Method to validate age, throws exception if age is less than 18
        {
            if (age < 18)
            {
                throw new ArgumentException("Age must be 18 or older.");
            }

            Console.WriteLine("Age is valid.");
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------------
    // Assignment 12. Custom Exception
    // Custom exception class for negative numbers
    public class NegativeNumberException : Exception
    {
        public string Message;
        public NegativeNumberException(string message)
        {
            Message = message;
        }
    }
    public class Negative
    {
        public static void CheckNumber(int number)
        {
            if (number < 0)
            {
                throw new NegativeNumberException($"Invalid input: {number} is a negative number.");
            }

            Console.WriteLine($"The number {number} is valid.");
        }
    }
    // ------------------------------------------------------------------------------------------------------------------------------
    // Assignment 13.Logging Exceptions
    public class Logger
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Logger));
        static Logger()
        {
            XmlConfigurator.Configure();
        }
        public static void LogError(string message, Exception ex)
        {
            log.Error(message, ex);
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------------
    // Assignment 14. Identify the Need for User-Defined Exceptions, Create Them, and Throw Them
    public class CheckNumber
    {
        public static void ProcessPositiveNumber(int number)
        {
            if (number < 0)
            {
                throw new NegativeNumberException($"Invalid input: {number} is a negative number.");
            }

            Console.WriteLine($"The number {number} is positive and accepted.");
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------------
    // Assignment 15. Explain the Difference between Exception (Checked Exceptions) and RuntimeException(Unchecked Exceptions)
    // Task 1: File Reading with Exception Handling:
    public class FileProcessor
    { 
        public void ReadFileContent(string filePath)            // Method to read file content and handle FileNotFoundException
        {
            try
            {
                StreamReader reader = new StreamReader(filePath);
                string content = reader.ReadToEnd();
                Console.WriteLine("File Content:");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File not found: {filePath}\n");
            }
        }
    }

    //-------------------------------------------------------------------
    // Task 2: Math Operation with Exception Handling:
    public class MathOperations
    {
        public double Divide(int numerator, int denominator)       // Method to divide two integers and handle DivideByZeroException
        {
            try
            {
                double result = numerator / denominator;
                return result;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\nCannot divide by zero.");
                return double.NaN;                   // Return NaN to pass an invalid result
            }
        }
    }

    //-------------------------------------------------------------------
    // Task 3: Custom Exception for Age Validation:
    // Custom exception class for invalid age
    public class InvalidAgeException : Exception
    {
        public string Message;
        public InvalidAgeException(string message)
        {
            Message = message;
        }
    }
    public class Person
    {
        public int Age;
        public void SetAge(int age)        // Method to set age with validation
        {
            if (age < 0 || age > 120)
            {
                throw new InvalidAgeException($"The age {age} is invalid. Age must be between 0 and 120.");
            }
            Age = age;
            Console.WriteLine("Age is Valid");
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------------
}
