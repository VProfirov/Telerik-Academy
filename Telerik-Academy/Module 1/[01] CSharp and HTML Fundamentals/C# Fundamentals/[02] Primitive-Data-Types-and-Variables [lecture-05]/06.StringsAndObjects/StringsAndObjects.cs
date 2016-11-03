/*
Problem 6. Strings and Objects

Declare two string variables and assign them with Hello and World.
Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
*/

namespace StringsAndObjects
{
    using System;

    class StringsAndObjects
    {
        static void Main()
        {
            string firstString = "Hello";
            string secondString = "World";

            object containerObject = firstString + " " + secondString;

            string fullString = (string)containerObject;

            Console.WriteLine(" These are the values stored respectively in :");
            Console.WriteLine();
            Console.WriteLine("First string: {0}", firstString);
            Console.WriteLine();
            Console.WriteLine("Second string: {0}", secondString);
            Console.WriteLine();
            Console.WriteLine("The object: {0}", containerObject);
            Console.WriteLine();
            Console.WriteLine("Final string: {0}", fullString);
            Console.WriteLine();
        }
    }
}