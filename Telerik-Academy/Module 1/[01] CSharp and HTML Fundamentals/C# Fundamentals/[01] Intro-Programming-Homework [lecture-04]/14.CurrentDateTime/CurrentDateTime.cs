/*
Problem 14.* Current Date and Time

Create a console application that prints the current date and time. Find out how in Internet.
*/

namespace CurrentDateTime
{
    using System;

    class CurrentDateTime
    {
        static void Main()
        {
            // The long way
            string calendar = DateTime.Now.ToShortDateString();
            string clock = DateTime.Now.ToShortTimeString();

            Console.WriteLine(calendar);
            Console.WriteLine(clock);

            Console.WriteLine();

            // The short way
            Console.WriteLine(DateTime.Now);

            //-----> Tests --->  NOTE : This is Output format testing section
            //Tests the formating of the Output AVOIDING hard-coding* the format(formating in manually *)
            // For more information look at : 
            // Main information point about time - http://www.dotnetperls.com/time
            // DateTime       - http://www.dotnetperls.com/datetime
            // DateTime Format- http://www.dotnetperls.com/datetime-format
            Console.WriteLine();
            Console.WriteLine("---------------BEGIN------------------");
            Console.WriteLine();

            DateTime time = DateTime.Now;
            string formatOfDateTime = "MMM ddd d HH:mm yyyy";

            Console.WriteLine(time.ToString(formatOfDateTime));

            Console.WriteLine();

            Console.WriteLine(time.ToString(format: "M d h:mm yy"));

            Console.WriteLine();
            Console.WriteLine("---------------END------------------");
            Console.WriteLine();
            //-----> Tests <--- END (begin at line 28)
        }
    }
}