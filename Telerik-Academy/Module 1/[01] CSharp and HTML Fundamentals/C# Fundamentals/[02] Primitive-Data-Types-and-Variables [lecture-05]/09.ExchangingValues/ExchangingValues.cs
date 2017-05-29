/*
Problem 9. Exchange Variable Values

Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
Print the variable values before and after the exchange.
*/

namespace ExchangingValues
{
    using System;

    class ExchangingValues
    {
        static void Main()
        {
            byte a = 5;
            byte b = 10;
            byte containterOfValues;

            Console.WriteLine("The value of \" a \" starts as {0} and the value of \" b \" starts as {1}", a, b);
            // exchange of values
            containterOfValues = a;
            a = b;
            b = containterOfValues;
            // -- ends --
            Console.WriteLine("At the end, the value of \" a \" is {0} and the value of \" b \" is {1}", a, b);

            Console.WriteLine();
        }
    }
}

/* This is example of "bitwise" universal value swap of all primitive numerical/integer types. It is allsow refered as swap using flags (1 and 0)
 a ^= b;
 b ^= a;
 a ^= b;
     */

/*
 *  byte a = 5;
 *  byte b = 10;
        a += b;
        b = a - b; // compiler error
        // Reason :  operator "-" supports int and long, but does not byte or short (if used a cast will be needed)
        // the other operators like ( + * / %), etc., too are not supported for byte and short
        a = (byte)(a - b); // cast of the result of (a and b) <=> (a-b) 
        // NB: every operator is a method with certain overloads. Ask for help or someone to explain to you operators,methods, overloading and overriding.
 */

/*  
   a -= b; //both are auto-casted to int 
 And is same as :
   a = a-b;   
 */