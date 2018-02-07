/*
Problem 12. Null Values Arithmetic

Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
*/

namespace NullValuesArithmetic
{
    using System;

    class NullValuesArithmetic
    {
        static void Main()
        {
            int? nullVauleInt = null;
            double? nullValueDouble = null;
            //print these variables at the console
            Console.WriteLine("First variable (int) \'{0}\' and second variable (double) \'{1}\'", nullVauleInt, nullValueDouble);
            // add null literal
            Console.WriteLine(nullVauleInt + null);
            // add a number
            Console.WriteLine(nullVauleInt + 12);
            nullVauleInt = 5;
            Console.WriteLine(nullVauleInt.GetValueOrDefault());
        }
    }
}