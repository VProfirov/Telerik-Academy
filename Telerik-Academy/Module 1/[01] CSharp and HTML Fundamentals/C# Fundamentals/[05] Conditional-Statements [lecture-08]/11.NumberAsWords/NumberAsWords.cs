/*Problem 11.	* Number as Words
Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
* Examples:

0	Zero
9	Nine
10	Ten
12	Twelve
19	Nineteen
25	Twenty five
98	Ninety eight
273	Two hundred and seventy three
400	Four hundred
501	Five hundred and one
617	Six hundred and seventeen
711	Seven hundred and eleven
999	Nine hundred and ninety nine

*/

namespace NumberAsWords
{
    using System;

    class NumberAsWords
    {
        static void Main()
        {
            //Creating matrix for each group
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] special = { "ten", "eleven", "twelve", "thirdtheen", "fourthen", "fiftheen", "sixtheen", "seventheen", "eightheen", "ninetheen" };
            string[] dec = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            int input = 0;

            Console.Write("Please enter a number in the range [0, 999] : ");
            //check for a correct input
            bool isValid = int.TryParse(Console.ReadLine(), out input);
            Console.WriteLine();

            if (isValid && input >= 0 && input < 1000)
            {
                int digit = input % 10;
                int tens = (input / 10) % 10;
                int hundred = (input / 100) % 10;

                if (hundred != 0)
                {
                    Console.Write("{0} hundred ", digits[hundred]);
                    if (tens != 0 && tens != 1 && input >= 20)
                    {
                        Console.Write("and {0} ", dec[tens]);
                        if (digit != 0)
                        {
                            Console.Write("{0} ", digits[digit]);
                        }
                    }
                    else if (tens == 1)
                    {
                        Console.Write("and {0}", special[digit]);
                    }
                    else
                    {
                        if (digit != 0)
                        {
                            Console.Write("and {0} ", digits[digit]);
                        }
                    }
                }
                else
                {
                    // hundreds = 0
                    if (tens != 0 && tens != 1 && input >= 20)
                    {
                        Console.Write("{0} ", dec[tens]);
                        Console.Write("{0} ", digits[digit]);
                    }
                    else if (tens == 1)
                    {
                        Console.Write("{0}", special[digit]);
                    }
                    else
                    {
                        Console.Write("{0} ", digits[digit]);
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Out of range, try again!");
                Main();
            }
            Console.WriteLine();
        }
    }
}