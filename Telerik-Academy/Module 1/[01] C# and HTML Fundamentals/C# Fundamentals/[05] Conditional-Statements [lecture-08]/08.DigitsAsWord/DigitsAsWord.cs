/*Problem 8.	Digit as Word
Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
Print “not a digit” in case of invalid inut. Use a switch statement. 
* Examples:
d	    result
2	    two
1	    one
0	    zero
5	    five
-0.1	not a digit
hi	    not a digit
9	    nine
10	    not a digit

*/

namespace DigitsAsWord
{
    using System;

    class DigitsAsWord
    {
        static void Main()
        {
            Console.WriteLine("This program names the digits entered (from 0 to 9).");
            Console.WriteLine();

            Console.Write("Enter a digit please: ");
            double input;
            bool inputTest = double.TryParse(Console.ReadLine(), out input);    

            if (inputTest)
            {
                //// (input % 1 == 0) <-- tests if the number(input) is integer or not
                if ((input >= 0) && (input <= 9) && (input % 1 == 0))
                {
                    int digit = (int)input;
                    switch (digit)
                    {
                        case 1:
                            Console.WriteLine("One");
                            break;
                        case 2:
                            Console.WriteLine("Two");
                            break;
                        case 3:
                            Console.WriteLine("Three");
                            break;
                        case 4:
                            Console.WriteLine("Four");
                            break;
                        case 5:
                            Console.WriteLine("Five");
                            break;
                        case 6:
                            Console.WriteLine("Six");
                            break;
                        case 7:
                            Console.WriteLine("Seven");
                            break;
                        case 8:
                            Console.WriteLine("Eight");
                            break;
                        case 9:
                            Console.WriteLine("Nine");
                            break;
                        case 0:
                            Console.WriteLine("Zero");
                            break;
                        default:
                            Console.WriteLine("not a digit");
                            break;
                    }
                    Console.WriteLine();              
                }
                else
                { 
                    Console.WriteLine("not a digit");    
                }
            }
            else
            {
                Console.WriteLine("not a digit");
            }
        }
    }
}
//// NOTES *!* : Very good way to test if a given number is a integer or not  --> (input % 1 != 0)