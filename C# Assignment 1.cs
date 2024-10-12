//Lab Assignment 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignments1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------
            //1
            /*Console.WriteLine("Hello World!");
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name);
            Console.ReadLine();*/

            //------------------------------------
            //2
            /*Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Age: ");
            string a = Console.ReadLine();
            Console.WriteLine("Your favourite color: ");
            string clr = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! You are {a} years old and your favourite color is {clr}");
            Console.ReadLine();*/

            //------------------------------------
            //3
            //Console.WriteLine("Enter two numbers a and b: ");
            //double a = Convert.ToInt32(Console.ReadLine());
            //double b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Sum is {a + b}");
            //Console.WriteLine($"Difference is {a - b}");
            //Console.WriteLine($"Product is {a * b}");
            //if (b == 0)
            //    Console.WriteLine("Warning! division by zero is not possible");
            //else
            //    Console.WriteLine($"Quotient is {a / b}");
            //Console.ReadLine();

            //------------------------------------
            //4
            //Console.WriteLine("Input a temperature in celcius: ");
            //double c = Convert.ToInt32(Console.ReadLine());
            ////Coverting into Farenheit
            //double f = (c * (9.0 / 5.0)) + 32.0;
            //Console.WriteLine($"The temperature in Farenheit is: {f}");
            //Console.ReadLine();

            //------------------------------------
            //5
            //Console.WriteLine("Enter the Principal Amount:");
            //int P = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Interest Rate:");
            //int R = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Time Period:");
            //int T = Convert.ToInt32(Console.ReadLine());
            ////Calculating Simple Interest
            //Console.WriteLine($"Simple Interest is : {(P * R * T) / 100.0}");
            //Console.ReadLine();

            //------------------------------------
            //6
            //const double PI = 3.14159;
            //Console.WriteLine("Enter the radius: ");
            //double r = Convert.ToDouble(Console.ReadLine());
            ////Calculating and Printing area of Circle
            //Console.WriteLine($"The area of Circle is: {PI * r * r}");
            //Console.ReadLine();

            //------------------------------------
            //7
            //Console.WriteLine("Enter the time in seconds: ");
            //int s = Convert.ToInt32(Console.ReadLine());
            ////Calculating hour
            //int hr = s / 3600;
            //s = s % 3600;
            ////Calculating minutes
            //int min = s / 60;
            //s = s % 60;
            ////Calculating seconds
            //int sec = s % 60;
            //Console.WriteLine($"The time is {hr}hr {min}min {sec}sec");
            //Console.ReadLine();

            //------------------------------------
            //8
            //Console.WriteLine("Enter the String: ");
            //string s = Console.ReadLine();
            //string st = s.Replace(" ", "");
            //int l = st.Length;
            //Console.WriteLine($"The no of characters in String: {l}");
            //Console.ReadLine();

            //------------------------------------
            //9
            //Console.WriteLine("Weight (in kg): ");
            //double weight = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Height (in m): ");
            //double height = Convert.ToDouble(Console.ReadLine());
            ////Calculating BMI
            //double BMI = weight / (height * height);
            //Console.WriteLine($"The BMI : {BMI}");
            //Console.ReadLine();

            //------------------------------------
            //10
            //int a = 7;
            //float b = 84.7f;
            //double c = 7.34;
            //char s = 'F';
            //string name = "Fiyaz";
            //bool value = true;
            //Console.WriteLine($"{a} (integer)");
            //Console.WriteLine($"{b} (float)");
            //Console.WriteLine($"{c} (double)");
            //Console.WriteLine($"{s} (char)");
            //Console.WriteLine($"{name} (string)");
            //Console.WriteLine($"{value} (boolean)");
            //Console.ReadLine();

            //------------------------------------
            //11
            //const double PI = 3.14159;
            //Console.WriteLine("Enter the radius of a circle: ");
            //double radius = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the lenght and breadth of a rectangle: ");
            //int lenght = Convert.ToInt32(Console.ReadLine());
            //int breadth = Convert.ToInt32(Console.ReadLine());
            ////Calculating and Printing area of Circle
            //Console.WriteLine($"The area of Circle is: {PI * radius * radius}");
            ////Calculating and Printing area of Rectangle
            //Console.WriteLine($"The area of Rectangle is: {lenght * breadth}");
            //Console.ReadLine();

            //------------------------------------
            //12
            //const double PI = 3.14159;
            //const int DAYS_IN_WEEK = 7;
            //Console.WriteLine("Enter the radius of a circle: ");
            //double radius = Convert.ToDouble(Console.ReadLine());
            ////Calculating Circumference of a circle
            //Console.WriteLine($"The Circumference of the Circle is: {2 * PI * radius} and the no of days in a week is: {DAYS_IN_WEEK}");
            //Console.ReadLine();

            //------------------------------------
            //13
            //const double INCH = 2.54;   //1 inch = 2.54 cm
            //Console.WriteLine("Enter the lenght and width of a rectangle in inches: ");
            //double lenght = Convert.ToDouble(Console.ReadLine());
            //double width = Convert.ToDouble(Console.ReadLine());
            ////Calculating and Printing area of Rectangle in square inches
            //Console.WriteLine($"The area of Rectangle (square inches) is: {lenght * width}");
            ////Calculating and Printing area of Rectangle in square centimeters
            //Console.WriteLine($"The area of Rectangle (square centimeters) is: {(lenght * INCH) * (width * INCH)}");
            //Console.ReadLine();

            //------------------------------------
            //14
            //Program to Read and Display details of an Employee 
            //Console.WriteLine("Enter the Employee name: ");
            //string employName = Console.ReadLine();
            //Console.WriteLine("Enter the Age: ");
            //int Age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Monthly Salary: ");
            //int monthlySalary = int.Parse(Console.ReadLine());
            ////Displaying Employee Details
            //Console.WriteLine("Employee Details:");
            //Console.WriteLine($"Name : {employName}");
            //Console.WriteLine($"Age : {Age}");
            //Console.WriteLine($"Monthy Salary : {monthlySalary}");
            //Console.ReadLine();

            //------------------------------------
            //15
            //int firstNumber = 5;
            //int secondNumber = 3;
            ////Calculating Sum
            //int Sum = firstNumber + secondNumber;
            //Console.WriteLine($"The sum of the two numbers is {Sum}");
            //Console.ReadLine();

            //------------------------------------
            //16
            ////Program to show use of assignment operator
            //int a = 7;
            //int b = 0;
            //b = a;
            //Console.WriteLine($"A: {a} and B: {b}");
            //Console.ReadLine();

            //------------------------------------
            //17
            //Console.WriteLine("Enter the base value: ");
            //double baseValue = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the exponential value: ");
            //double exponentValue = Convert.ToInt32(Console.ReadLine());
            ////Calculating power of the number
            //double answer = Math.Pow(baseValue, exponentValue);
            //Console.WriteLine($"The answer is {answer}");
            //Console.ReadLine();

            //------------------------------------
            //18
            //Console.WriteLine("Enter the age of the person: ");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Nationality: ");
            //string Citizenship = Console.ReadLine();
            //if (Age >= 18 && Citizenship.ToLower() == "indian")
            //    Console.WriteLine("The person is Eligible for voting");
            //else
            //    Console.WriteLine("The person is not Eligible for voting");
            //Console.ReadLine();

            //------------------------------------
            //19
            //Console.WriteLine("Enter the Age of the person: ");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Income of the person: ");
            //int Income = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the outstanding Loan Status(Yes/No) of the person: ");
            //string loanStatus = Console.ReadLine();
            //if (Age >= 21 && Income >= 30000 && loanStatus.ToLower() == "no")
            //    Console.WriteLine("The person is Eligible for Loan");
            //else
            //    Console.WriteLine("The person is not Eligible for Loan");
            //Console.ReadLine();

            //------------------------------------
            //20
            //Console.WriteLine("Enter the Age of the person: ");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Work Experience of the person: ");
            //int workExperience = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Whether the person have college degree (Yes/No): ");
            //string degreeStatus = Console.ReadLine();
            //if (Age >= 18 && Age <= 35 && workExperience >= 2 && (degreeStatus.ToLower() == "yes" || workExperience >= 5))
            //    Console.WriteLine("The person is Eligible for the Job");
            //else
            //    Console.WriteLine("The person is not Eligible for the Job");
            //Console.ReadLine();

            //------------------------------------
            //21
            //Console.WriteLine("Enter a character: ");
            //char ch = Convert.ToChar(Console.ReadLine());

            //// Checking if the character ch is a vowel or not.
            //if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E'
            //    || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O'
            //    || ch == 'u' || ch == 'U')
            //{
            //    Console.WriteLine($"The character {ch} is a vowel.");
            //}
            //else
            //{
            //    Console.WriteLine($"The character {ch} is a consonant");
            //}

            //------------------------------------
            //22
            //Console.WriteLine("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            ////Checking if a number is positive, negative or zero
            //if (number > 0)
            //    Console.WriteLine($"The number {number} is a positive number");
            //else if (number < 0)
            //    Console.WriteLine($"The number {number} is a negative number");
            //else
            //    Console.WriteLine($"The number {number} is zero");

            //------------------------------------
            //23
            //Console.WriteLine("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            ////Checking if a number is divisible by 5 and 11
            //if (number % 5 == 0 && number % 11 == 0)
            //    Console.WriteLine($"The number {number} is divisible by both 5 and 11");
            //else
            //    Console.WriteLine($"The number {number} is not divisible by both 5 and 11");

            //--------------------------------------------------------------------------------------
            //24
            //Console.Write("Enter the first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter an operator (+, -, *, /): ");
            //char op = Convert.ToChar(Console.ReadLine());

            //if (op == '+')
            //{
            //    Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
            //}
            //else if (op == '-')
            //{
            //    Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
            //}
            //else if (op == '*')
            //{
            //    Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
            //}
            //else if (op == '/')
            //{
            //    if (num2 != 0)
            //    {
            //        Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error: Division by zero is not allowed.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid operator! Please enter one of the following: +, -, *, /");
            //}
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------
            //25
            //Console.Write("Enter the student's marks (out of 100): ");
            //int marks = Convert.ToInt32(Console.ReadLine());

            //if (marks >= 0 && marks <= 100) 
            //{
            //    if (marks >= 90)
            //    {
            //        Console.WriteLine("Grade: A");
            //    }
            //    else if (marks >= 80)
            //    {
            //        Console.WriteLine("Grade: B");
            //    }
            //    else if (marks >= 70)
            //    {
            //        Console.WriteLine("Grade: C");
            //    }
            //    else if (marks >= 60)
            //    {
            //        Console.WriteLine("Grade: D");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Grade: F");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid marks! Please enter a value between 0 and 100.");
            //}
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------
            //26
            //Console.WriteLine("Swapping using a third variable");
            //Console.WriteLine("Enter the first number: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the second number: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Before Swap: a = {a}, b = {b}");

            //int temp = a;
            //a = b;
            //b = temp;

            //Console.WriteLine($"After Swap: a = {a}, b = {b}");


            //Console.WriteLine("\nSwapping without using a third variable:");


            //Console.WriteLine("Enter the first number: ");
            //a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //b = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine($"Before Swap: a = {a}, b = {b}");


            //a = a + b;
            //b = a - b;
            //a = a - b;


            //Console.WriteLine($"After Swap: a = {a}, b = {b}");

            //Console.ReadLine();


            //--------------------------------------------------------------------------------------
            //27
            //Console.Write("Enter the first number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //int temp1 = num1;
            //int temp2 = num2;

            //// Perform and display arithmetic operations
            //Console.WriteLine("\nArithmetic Operations:");
            //// Addition
            //int sum = num1 + num2;
            //Console.WriteLine($"{num1} + {num2} = {sum}");
            //// Subtraction
            //int difference = num1 - num2;
            //Console.WriteLine($"{num1} - {num2} = {difference}");
            //// Multiplication
            //int product = num1 * num2;
            //Console.WriteLine($"{num1} * {num2} = {product}");
            //// Division
            //if (num2 != 0)
            //{
            //    double quotient = (double)num1 / num2;
            //    Console.WriteLine($"{num1} / {num2} = {quotient}");
            //}
            //else
            //{
            //    Console.WriteLine("Division by zero is not allowed.");
            //}
            //// Modulus (remainder)
            //if (num2 != 0)
            //{
            //    int remainder = num1 % num2;
            //    Console.WriteLine($"{num1} % {num2} = {remainder}");
            //}
            //else
            //{
            //    Console.WriteLine("Modulus by zero is not allowed.");
            //}
            //// Increment and Decrement operations
            //Console.WriteLine($"\nBefore Increment: num1 = {num1}, num2 = {num2}");
            //// Incrementing num1 and num2
            //num1++;
            //num2++;
            //Console.WriteLine($"After Increment: num1 = {num1}, num2 = {num2}");
            //// Decrementing num1 and num2
            //temp1--;
            //temp2--;
            //Console.WriteLine($"After Decrement: num1 = {temp1}, num2 = {temp2}");
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------
            //28
            //Console.Write("Enter the first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the third number: ");
            //double num3 = Convert.ToDouble(Console.ReadLine());

            //// Calculate the average
            //double average = (num1 + num2 + num3) / 3;

            //// Display the average with two decimal places
            //Console.WriteLine($"\nThe average of {num1}, {num2}, and {num3} is: {average:F2}");
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------
            //29
            //double conversionRate = 0.85;

            //Console.Write("Enter the amount in USD: ");
            //double usdAmount = Convert.ToDouble(Console.ReadLine());

            //double eurAmount = usdAmount * conversionRate;

            //Console.WriteLine($"\n{usdAmount} USD is equivalent to {eurAmount:F2} EUR.");
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------
            //30
            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num >= 1 && num <= 100)
            //{
            //        if (num % 2 == 0)
            //        {
            //            Console.WriteLine($"{num} is an even number.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{num} is an odd number.");
            //        }
            //}
            //else
            //{
            //    Console.WriteLine($"The number is not within the range.");
            //}
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------
            //31
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 3 == 0 && number % 5 != 0)
            //{
            //    Console.WriteLine($"{number} is divisible by 3 but not by 5.");
            //}
            //else if (number % 5 == 0 && number % 3 != 0)
            //{
            //    Console.WriteLine($"{number} is divisible by 5 but not by 3.");
            //}
            //else if (number % 3 == 0 && number % 5 == 0)
            //{
            //    Console.WriteLine($"{number} is divisible by both 3 and 5.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not divisible by both 3 and 5.");
            //}
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------
            //32
            //Console.WriteLine("Enter the year");
            //int year = Convert.ToInt32(Console.ReadLine());

            //if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            //{
            //    Console.WriteLine($"{year} is a leap year");
            //}
            //else
            //{
            //    Console.WriteLine($"{year} is not a leap year");
            //}
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------
            //33
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //// Check if the number is positive
            //if (number > 0)
            //{
            //    Console.WriteLine($"{number} is positive.");

            //    // Check if the number is greater than 50
            //    if (number > 50)
            //    {
            //        Console.WriteLine($"{number} is greater than 50.");

            //        // Check if the number is even
            //        if (number % 2 == 0)
            //        {
            //            Console.WriteLine($"{number} is even.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{number} is odd.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{number} is not greater than 50.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not positive.");
            //}
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------
            //34
            //int subject1, subject2, subject3;
            //int passmark = 40;
            //int totalsubjects = 3;

            //Console.WriteLine("Enter the marks for three subjects:");

            //Console.Write("Subject 1: ");
            //subject1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Subject 2: ");
            //subject2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Subject 3: ");
            //subject3 = Convert.ToInt32(Console.ReadLine());

            //bool allpassed = (subject1 >= passmark && subject2 >= passmark && subject3 >= passmark);
            //if(allpassed)
            //{
            //    double average = (subject1 + subject2 + subject3)/(double)totalsubjects;

            //    if(average >= 70)
            //    {
            //        Console.WriteLine("The student has passed in all subjects with Distinction.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The student has passed in all subjects but did not achieve Distinction.");
            //    }
            //}
            //else
            //{
            //    int failedsubjects = 0;
            //    if (subject1 < passmark) failedsubjects++;
            //    if (subject2 < passmark) failedsubjects++;
            //    if (subject3 < passmark) failedsubjects++;

            //    Console.WriteLine($"The student has failed in {failedsubjects} subjects.");
            //}
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------
            //35
            Console.Write("Enter your annual salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            // Variable to store taxable income
            double taxableIncome = salary;
            // Check if the employee is a senior citizen (60 or above)
            if (age >= 60)
            {
                // Provide additional tax exemption for senior citizens
                taxableIncome -= 5000;
            }
            // Initialize tax variable
            double tax = 0;
            // Calculate tax based on the taxable income
            if (taxableIncome < 10000)
            {
                tax = 0; // No tax
            }
            else if (taxableIncome >= 10000 && taxableIncome <= 50000)
            {
                tax = taxableIncome * 0.10; // 10% tax
            }
            else // taxableIncome > 50000
            {
                tax = taxableIncome * 0.20; // 20% tax
            }
            // Print the tax amount to be paid
            Console.WriteLine($"The tax to be paid is: {tax:F2}");

            Console.ReadLine();
        }
    }
}
