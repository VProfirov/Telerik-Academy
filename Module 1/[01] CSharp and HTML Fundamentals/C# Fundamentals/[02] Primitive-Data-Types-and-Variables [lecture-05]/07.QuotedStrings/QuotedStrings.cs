/*
Problem 7. Quotes in Strings

Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
Do the above in two different ways - with and without using quoted strings.
Print the variables to ensure that their value was correctly defined.
*/

namespace QuotedStrings
{
    using System;

    class QuotedStrings
    {
        static void Main()
        {
            string firstString = "The \"use\" of quotations causes difficulties.";
            string secondString = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine("The strings forms and returned data: ");
            Console.WriteLine();
            Console.WriteLine("Form : \"The \\\"use\\\" of quotations causes difficulties.\"");
            Console.WriteLine("Result : {0}", firstString);
            Console.WriteLine();

            char specialEscaping = '@';

            Console.WriteLine("Form:  " + specialEscaping + "\"The \"\"use\"\" of quotations causes difficulties.\"");
            Console.WriteLine("Result : {0}", secondString);
            Console.WriteLine();
        }
    }
}