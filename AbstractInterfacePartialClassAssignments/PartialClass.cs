using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbstractInterfacePartialClassAssignments
{
    //C# Assignments on Abstract Class, Interface and Partial Class
    //--------------------------------------------------------------------------------------------------------------------------------------------
    //Assignment 7. Partial Class
    public partial class Person     //Partial class Person with method ShowDetails
    {
        public void ShowDetails()
        {
            Console.WriteLine($"Name : {Name}");
        }
    }

    //--------------------------------------------------------------------------------------------------------------------------------------------
    //Assignment 8. Partial Methods
    public partial class Employee
    {
        double totalSalary;
        partial void CalculateSalary()     // Implementation of the partial method
        {
            totalSalary = ratePerHour * hours;
        }
        public void DisplaySalary()
        {
            CalculateSalary();     // Calling the partial method to calculate salary
            Console.WriteLine($"Employee: {name}, Salary: {totalSalary:C}");
        }
    }

    //--------------------------------------------------------------------------------------------------------------------------------------------
}
