/*
Problem 2. Float or Double?

Which of the following values can be assigned to a variable of type float and which to a variable of type double:
34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them to ensure no precision is lost.
*/

namespace FloatOrDouble
{
    using System;

    class FloatOrDouble
    {
        static void Main()
        {
            float firstNumber = 12.345f;
            float secondNumber = 3456.091f;
            double thirdNumber = 34.567839023;
            double fourthNumber = 8923.1234857;

            Console.WriteLine(" Float is {0}", firstNumber);
            Console.WriteLine(" Float is {0}", secondNumber);
            Console.WriteLine(" Double is {0}", thirdNumber);
            Console.WriteLine(" Double is {0}", fourthNumber); 
        }
    }
}

// NOTE: IF the number of digits is ( counter <= 7 ) then the number is float ELSE it is double
// Float 7 digits | Double 15-16 digits

// Or just use "var" and the compiler will assign the type accordingly 
// TODO: Check using "var" for more complex data types. Also its use as a "good practice".