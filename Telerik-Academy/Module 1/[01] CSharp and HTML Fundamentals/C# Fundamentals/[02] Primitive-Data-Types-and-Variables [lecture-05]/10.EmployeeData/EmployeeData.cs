/*
Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
*/

namespace EmployeeData
{
    using System;

    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Mad";
            string lastName = "Max";
            byte age = 41;
            char gender = 'm';
            long idNumber = 27560101;
            uint uniqueNumber = 27560001;

            Console.WriteLine("Employee data : ");
            Console.WriteLine();
            Console.WriteLine("First name : {0}", firstName);
            Console.WriteLine("Family name : {0}", lastName);
            Console.WriteLine("Age : {0}", age);
            Console.WriteLine("Gender : {0}", gender);
            Console.WriteLine("ID : {0}", idNumber);
            Console.WriteLine("Unique employee number : {0}", uniqueNumber);
            Console.WriteLine();
        }
    }
}