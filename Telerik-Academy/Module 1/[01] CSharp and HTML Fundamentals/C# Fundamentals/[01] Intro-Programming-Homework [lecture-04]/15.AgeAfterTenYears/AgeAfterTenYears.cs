/*
Problem 15.* Age after 10 Years

Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
*/

namespace AgeAfterTenYears
{
    using System;

    class AgeAfterTenYears
    {
        static void Main()
        { 
            // INFO:
            /*
             * Main : http://www.dotnetperls.com/datetime
             *        http://msdn.microsoft.com/en-us/library/System.DateTime_properties(v=vs.110).aspx
             *    
             * NB! Example of year extraction : http://stackoverflow.com/questions/1965087/extract-year-from-datetime-format
             * 
             * DateTime Elapsed     :   http://www.dotnetperls.com/datetime-elapsed
             * DateTime Substract   :   http://www.dotnetperls.com/datetime-subtract
             * Timespan             :   http://www.dotnetperls.com/timespan  
             */


            Console.WriteLine("Please enter your birthday like this : ");
            Console.WriteLine("If, for example, you where born on the 5th of October 1988 ---> 05.10.1988 \r\n");

            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();

            int yearsOld = (DateTime.Now.Year) - (birthDate.Year);
            //Console.WriteLine("You are at {0}", yearsOld);

            //Check for the month and the date, so you don't have 1 year more before your birthday date
            if ((DateTime.Now.Month < birthDate.Month) || ((DateTime.Now.Month == birthDate.Month) && (DateTime.Now.Day < birthDate.Day)))
            {
                yearsOld = yearsOld - 1;
            }

            int yearsOldAfterTen = yearsOld + 10;

            Console.Write("You have entered ");
            Console.Write(birthDate.ToString("d MMM yyyy"));

            Console.WriteLine(", so you are at {0}", yearsOld);

            Console.WriteLine("and after 10 years you will be at {0} .", yearsOldAfterTen);

            #region Test

            /*
            //Console.WriteLine("10.05.1987");
            string inputBirthday ="10.05.1987";

            DateTime birthDate = DateTime.Parse(inputBirthday);

            //Console.WriteLine(birthDate.ToString("d MMM dddddd yyyy"));

            // shows how old are you now
            int yearsOld = (DateTime.Now.Year) - (birthDate.Year);
            Console.WriteLine("You are at {0}", yearsOld);

            int yearsOldAfterTen = yearsOld + 10;

            Console.Write(birthDate.ToString("d MMM yyyy"));
            Console.Write(" was - ");
            Console.Write(birthDate.ToString("dddddd"));
            Console.WriteLine(". So after 10 years you will be on {0}", yearsOldAfterTen);
            
             */

            #endregion

        }
    }
}