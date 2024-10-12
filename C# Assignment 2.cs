// Lab Assignment 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------------
            //1
            //Console.WriteLine("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The multiplication table of {number}: ");
            ////Printing multiplication table of a number
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{number} * {i} = {number * i}");
            //}

            //--------------------------------------------------------
            //2
            //Console.WriteLine("Enter the no of rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //--------------------------------------------------------
            //3 Sum of all even numbers between 1 and 100 using while loop
            //int number = 2;
            //int sum = 0;
            //while (number <= 100)
            //{
            //    sum += number;
            //    number += 2;
            //}
            //Console.WriteLine($"The sum of even numbers between 1 and 100 is {sum}");
            //Console.ReadLine();

            //--------------------------------------------------------
            //4 Multiplication table from 1 to 5
            //int i = 1;
            //while (i <= 5)
            //{
            //    int j = 1;
            //    while (j <= 10)
            //    {
            //        Console.WriteLine($"{i} X {j} = {i * j}");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}
            //Console.ReadLine();

            //--------------------------------------------------------
            //5 Print positive number and stops when user enters a negative number
            //int number;
            //do
            //{
            //    Console.WriteLine("Enter a positive number");
            //    number = Convert.ToInt32(Console.ReadLine());

            //    if (number >= 0)
            //    {
            //        Console.WriteLine($"The {number} is a positive number");
            //    }
            //} while (number >= 0);
            //Console.WriteLine("The entered number is a negative number");
            //Console.ReadLine();

            //--------------------------------------------------------
            //6 Create Menu Driven Calculator
            //int choice;
            //do
            //{
            //    Console.WriteLine("1. Add");
            //    Console.WriteLine("2. Subtract");
            //    Console.WriteLine("3. Multiply");
            //    Console.WriteLine("4. Divide");
            //    Console.WriteLine("5. Exit");
            //    Console.WriteLine("Enter the choice");
            //    choice = Convert.ToInt32(Console.ReadLine());

            //    if (choice == 5)
            //    {
            //        Console.WriteLine("Exiting");
            //        break;
            //    }

            //    Console.WriteLine("Enter the first number");
            //    double num1 = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Enter the second number");
            //    double num2 = Convert.ToDouble(Console.ReadLine());

            //    switch (choice)
            // {
            //        case 1:
            //            Console.WriteLine($"{num1}+{num2} = {num1 + num2}");
            //            break;
            //        case 2:
            //            Console.WriteLine($"{num1}-{num2} = {num1 - num2}");
            //            break;
            //        case 3:
            //            Console.WriteLine($"{num1}*{num2} = {num1 * num2}");
            //            break;
            //        case 4:
            //            if (num2 != 0)
            //            {
            //                Console.WriteLine($"{num1}/{num2} = {num1 / num2}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Division b y zero is not possible");
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Invalid choice");
            //            break;
            //    }
            //} while (choice != 5);
            //    Console.ReadLine();

            //--------------------------------------------------------
            //7 Print all numbers from 1 to 100
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        continue;
            //    }
            //    if (i > 50)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //--------------------------------------------------------
            //8 Sum of all odd numbers between 1 and 100 using for loop
            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine($"The sum of odd numbers between 1 and 100 is {sum}");
            //Console.ReadLine();

            //--------------------------------------------------------
            //9 Factorial of a given number using while loop
            //Console.WriteLine("Enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int factorial = 1;
            //int i = number;

            //while (i > 1)
            //{
            //    factorial *= i;
            //    i--;
            //}
            //Console.WriteLine($"The Factorial of {number} is {factorial}");
            //Console.ReadLine();

            //--------------------------------------------------------
            //10 Print a number pyramid using nested while loop
            //int rows = 5;
            //int i = 1;

            //while (i <= rows)
            //{
            //    int j = 1;

            //    while (j <= i)
            //    {
            //        Console.Write(i + " ");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}
            //Console.ReadLine();

            //--------------------------------------------------------
            //11 Guess the number game
            //while (true)
            //{
            //    int number = new Random().Next(1, 101);

            //    Console.WriteLine("Guess the number");
            //    while (true)
            //    {

            //        int enteredNumber = Convert.ToInt32(Console.ReadLine());

            //        if (enteredNumber == number)
            //        {
            //            Console.WriteLine("Congratulations. You won!!");
            //            break;

            //        }
            //        else if (enteredNumber > number)
            //        {
            //            Console.WriteLine("Too high. Try again.");
            //        }
            //        else if (enteredNumber < number)
            //        {
            //            Console.WriteLine("Too low. Try again.");
            //        }
            //    }
            //    Console.WriteLine("Do you want to play again? Yes/No");
            //    string decision = Console.ReadLine();
            //    if (decision.ToLower() == "yes")
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //--------------------------------------------------------
            //12 Simple calculator using switch statement
            //double num1, num2, result = 0;
            //char operation;

            //Console.WriteLine("Enter the first number");
            //num1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the second number");
            //num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Choose an operation(+,-,*,/)");
            //operation =  Convert.ToChar(Console.ReadLine());

            //switch (operation)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            //        break;
            //    case '/':
            //        if (num2 != 0)
            //        {
            //            result = num1 / num2;
            //            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Division by zero is not possible");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Operation");
            //        break;
            //}
            //Console.ReadLine();

            //--------------------------------------------------------
            //13 Sum of digits
            //Console.WriteLine("Enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;
            //int digit;

            //do
            //{
            //    digit = number % 10;
            //    sum += digit;
            //    number /= 10;
            //}while(number > 0);

            //Console.WriteLine($"The sum of the digits of is {sum}");
            //Console.ReadLine();

            //--------------------------------------------------------
            //14 Finding the largest number
            //int largestnumber = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Enter number" + i + ":");
            //    int number = Convert.ToInt32(Console.ReadLine());

            //    if (number > largestnumber)
            //    {
            //        largestnumber = number;
            //    }
            //}
            //Console.WriteLine("The largest number is:" + largestnumber);
            //Console.ReadLine();

            //--------------------------------------------------------
            //15 Sum of squares from 1 to a user provided number using while loop
            //Console.WriteLine("Enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int sumofsquares = 0;
            //int i = 1;

            //while(i <= number)
            //{
            //    sumofsquares += i * i;
            //    i++;
            //}
            //Console.WriteLine($"The sum of squares from 1 to {number} is {sumofsquares}");
            //Console.ReadLine();

            //--------------------------------------------------------
            //16 Countdown timer from 10 to 1 using a do while loop displaying each second
            //int countdown = 10;
            //do
            //{
            //    Console.WriteLine(countdown);
            //    Thread.Sleep(1000);
            //    countdown--;
            //} while (countdown > 0);
            //Console.ReadLine();

            //--------------------------------------------------------
            //17 Find and print the first  multiples of 5 in a given list of numbers. Use the break statement to exit the loop once a multiple of 5 is found
            //List<int> numbers = new List<int> { 13, 8, 15, 20, 43, 45, 70, 86, 80, 25, 29,100, 8 };

            //int firstmultiple = 0;
            //bool found = false;
            //foreach (int number in numbers)
            //{
            //        if (number % 5 == 0)
            //        {
            //            firstmultiple = number;
            //            found = true;
            //            break;
            //        }
            //}
            //if (found)
            //{
            //    Console.WriteLine("The first multiple of 5 is" + firstmultiple);
            //}
            //else
            //{
            //    Console.WriteLine("No multiples found");
            //}
            //Console.ReadLine();

            //--------------------------------------------------------
            //18 Program to print non multiples of 3
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //--------------------------------------------------------
            //19 Palindrome using while loop
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int originalNumber = number;
            //int reversedNumber = 0;

            //while (number > 0)
            //{
            //    int remainder = number % 10;
            //    reversedNumber = (reversedNumber * 10) + remainder;
            //    number /= 10;
            //}

            //if (originalNumber == reversedNumber)
            //{
            //    Console.WriteLine($"{originalNumber} is a palindrome.");
            //}
            //else
            //{
            //    Console.WriteLine($"{originalNumber} is not a palindrome.");
            //}
            //Console.ReadLine();

            //--------------------------------------------------------
            //20 average of positive numbers
            //int sum = 0;
            //int count = 0;
            //int number;

            // Use do-while loop to ensure at least one input is taken
            //do
            //{
            //    Console.Write("Enter a positive number (or a negative number to stop): ");
            //    number = Convert.ToInt32(Console.ReadLine());

            //    if (number >= 0)
            //    {
            //        sum += number;
            //        count++;
            //    }

            //} while (number >= 0); // Loop continues while the number is non-negative

            //if (count > 0)
            //{
            //    double average = (double)sum / count;
            //    Console.WriteLine($"The average of the entered positive numbers is: {average}");
            //}
            //else
            //{
            //    Console.WriteLine("No positive numbers were entered.");
            //}
            //Console.ReadLine();

            //--------------------------------------------------------
            //21 Reverse a number using do while loop
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int reversedNumber = 0;

            //do
            //{
            //    int remainder = number % 10;
            //    reversedNumber = (reversedNumber * 10) + remainder;
            //    number /= 10;
            //} while (number > 0);

            //Console.WriteLine($"The reversed number is: {reversedNumber}");
            //Console.ReadLine();

            //--------------------------------------------------------
            //22 Menu Driven String Operations
            //Console.Write("Enter a string: ");
            //string inputString = Console.ReadLine();

            //Console.WriteLine("\nChoose an operation:");
            //Console.WriteLine("1. Reverse the string");
            //Console.WriteLine("2. Convert to uppercase");
            //Console.WriteLine("3. Convert to lowercase");
            //Console.WriteLine("4. Find the length of the string");

            //Console.Write("\nEnter your choice (1-4): ");
            //int choice = Convert.ToInt32(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        // Reversing the string without calling a method
            //        string reversedString = "";
            //        for (int i = inputString.Length - 1; i >= 0; i--)
            //        {
            //            reversedString += inputString[i];
            //        }
            //        Console.WriteLine($"Reversed string: {reversedString}");
            //        break;

            //    case 2:
            //        string upperCaseString = inputString.ToUpper();
            //        Console.WriteLine($"Uppercase string: {upperCaseString}");
            //        break;

            //    case 3:
            //        string lowerCaseString = inputString.ToLower();
            //        Console.WriteLine($"Lowercase string: {lowerCaseString}");
            //        break;

            //    case 4:
            //        int length = inputString.Length;
            //        Console.WriteLine($"Length of the string: {length}");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid choice! Please select a valid option (1-4).");
            //        break;
            //}
            //Console.ReadLine();

            //--------------------------------------------------------
            //23 Skip multiples of 4
            //for (int i = 1; i <= 50; i++)
            //{
            //    // Check if the number is divisible by 4
            //    if (i % 4 == 0)
            //    {
            //        continue; // Skip this iteration
            //    }

            //    // Print the number if it's not divisible by 4
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //--------------------------------------------------------
            //24 Fibonacci sequence
            //int count = 10; // Number of Fibonacci numbers to print
            //int firstNumber = 0; // First number in the Fibonacci sequence
            //int secondNumber = 1; // Second number in the Fibonacci sequence

            //Console.WriteLine("The first 10 numbers in the Fibonacci sequence:");

            //// Loop to calculate and print the Fibonacci sequence
            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine(firstNumber); // Print the current Fibonacci number

            //    // Calculate the next number in the sequence
            //    int nextNumber = firstNumber + secondNumber;

            //    // Update the previous two numbers
            //    firstNumber = secondNumber;
            //    secondNumber = nextNumber;
            //}
            //Console.ReadLine();

            //--------------------------------------------------------
            //25 Find all armstrong numbers
            //Console.WriteLine("Armstrong numbers between 1 and 500:");

            //int number = 1; // Start checking from 1

            //while (number <= 500)
            //{
            //    int originalNumber = number;
            //    int sumOfCubes = 0;

            //    // Calculate the sum of the cubes of the digits
            //    while (originalNumber > 0)
            //    {
            //        int digit = originalNumber % 10; // Get the last digit
            //        sumOfCubes += digit * digit * digit; // Add the cube of the digit
            //        originalNumber /= 10; // Remove the last digit
            //    }

            //    // Check if the number is an Armstrong number
            //    if (sumOfCubes == number)
            //    {
            //        Console.WriteLine(number);
            //    }

            //    number++; // Move to the next number
            //}
            //Console.ReadLine();

            //--------------------------------------------------------
            //26 Menu Driven Number System Conversion
            //while (true) // Keep the menu running until the user decides to exit
            //{
            //    Console.WriteLine("\nNumber Conversion Menu:");
            //    Console.WriteLine("1. Binary to Decimal");
            //    Console.WriteLine("2. Decimal to Binary");
            //    Console.WriteLine("3. Decimal to Hexadecimal");
            //    Console.WriteLine("4. Exit");
            //    Console.Write("Enter your choice (1-4): ");

            //    int choice = Convert.ToInt32(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1: // Binary to Decimal
            //            Console.Write("Enter a binary number: ");
            //            string binaryInput = Console.ReadLine();
            //            int decimalValue = Convert.ToInt32(binaryInput, 2);
            //            Console.WriteLine($"Decimal value: {decimalValue}");
            //            break;

            //        case 2: // Decimal to Binary
            //            Console.Write("Enter a decimal number: ");
            //            int decimalNumber = Convert.ToInt32(Console.ReadLine());
            //            string binaryResult = Convert.ToString(decimalNumber, 2);
            //            Console.WriteLine($"Binary value: {binaryResult}");
            //            break;

            //        case 3: // Decimal to Hexadecimal
            //            Console.Write("Enter a decimal number: ");
            //            int decimalForHex = Convert.ToInt32(Console.ReadLine());
            //            string hexValue = Convert.ToString(decimalForHex, 16).ToUpper();
            //            Console.WriteLine($"Hexadecimal value: {hexValue}");
            //            break;

            //        case 4: // Exit
            //            Console.WriteLine("Exiting the program.");
            //            return; // Exit the Main method

            //        default: // Invalid choice
            //            Console.WriteLine("Invalid choice! Please select a valid option (1-4).");
            //            break;
            //    }
            //}
            //Console.ReadLine();

            //--------------------------------------------------------
            //27 Reverse a string
            //Console.Write("Enter a string: ");
            //string inputString = Console.ReadLine();
            //string reversedString = "";

            //// Loop to reverse the string
            //for (int i = inputString.Length - 1; i >= 0; i--)
            //{
            //    reversedString += inputString[i]; // Append each character in reverse order
            //}

            //Console.WriteLine($"Reversed string: {reversedString}");
            //Console.ReadLine();

            //--------------------------------------------------------
            //28 Count vowels and consonants in a string
            //Console.Write("Enter a string: ");
            //string inputString = Console.ReadLine();

            //int vowelCount = 0;    // To store the number of vowels
            //int consonantCount = 0; // To store the number of consonants

            //// Convert the string to lowercase to make the comparison case-insensitive
            //inputString = inputString.ToLower();

            //// Loop through each character in the string
            //for (int i = 0; i < inputString.Length; i++)
            //{
            //    char currentChar = inputString[i];

            //    // Check if the character is a letter
            //    if (char.IsLetter(currentChar))
            //    {
            //        // Check if the character is a vowel
            //        if (currentChar == 'a' || currentChar == 'e' || currentChar == 'i' ||
            //            currentChar == 'o' || currentChar == 'u')
            //        {
            //            vowelCount++; // Increment vowel count
            //        }
            //        else
            //        {
            //            consonantCount++; // Increment consonant count
            //        }
            //    }
            //}

            //// Display the counts
            //Console.WriteLine($"Number of vowels: {vowelCount}");
            //Console.WriteLine($"Number of consonants: {consonantCount}");
            //Console.ReadLine();

            //--------------------------------------------------------
            //29 Find Maximum and Minimum of 5 numbers
            //Console.WriteLine("Enter 5 numbers:");

            //// Initialize variables to hold the maximum and minimum values
            //int max = int.MinValue; 
            //int min = int.MaxValue; 

            //// Loop to read 5 numbers from the user
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Enter number {i + 1}: ");
            //    int number = Convert.ToInt32(Console.ReadLine());

            //    // Update maximum and minimum values
            //    if (number > max)
            //    {
            //        max = number; // Update max if the current number is greater
            //    }

            //    if (number < min)
            //    {
            //        min = number; // Update min if the current number is smaller
            //    }
            //}

            //// Display the results
            //Console.WriteLine($"Maximum number: {max}");
            //Console.WriteLine($"Minimum number: {min}");
            //Console.ReadLine();

            //--------------------------------------------------------
            //30 Count digits of a number
            Console.Write("Enter a number: ");
            int number = Math.Abs(Convert.ToInt32(Console.ReadLine())); // Take absolute value to handle negative numbers

            int count = 0; // Variable to count the digits

            // Handle the case when the input number is 0
            if (number == 0)
            {
                count = 1; // 0 has one digit
            }
            else
            {
                // Use a while loop to count the digits
                while (number > 0)
                {
                    number /= 10; // Remove the last digit
                    count++;      // Increment the digit count
                }
            }
            Console.WriteLine($"Number of digits:{count}");

            Console.ReadLine();
        }
    }
}
