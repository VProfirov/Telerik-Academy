/*Beer Time
A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt”
(an hour in range [01...12], a minute in range [00…59] and AM / PM designator)
and prints “beer time” or “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed.
Note that you may need to learn how to parse dates and times.
* Examples:
time	    result
1:00 PM	    beer time
4:30 PM	    beer time
10:57 PM	beer time
8:30 AM	    non-beer time
02:59 AM	beer time
03:00 AM	non-beer time
03:26 AM	non-beer time
*/
namespace BeerTime
{
    using System;
    using System.Globalization;

    class BeerTime
    {
        static void Main()
        {
            CultureInfo enUS = new CultureInfo("en-US");
            DateTime time;
            
            DateTime startTime = DateTime.Parse("1:00 PM");
            DateTime endTime = DateTime.Parse("3:00 AM");

            Console.Write("Enter a time in format \"hh:mm tt\" (Example: 04:32 PM) ");
            string dateString = Console.ReadLine();

            if (DateTime.TryParseExact(dateString, "h:mm tt", enUS,
                DateTimeStyles.None, out time))
            {
                if (time > startTime || time < endTime)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            else
            {
                Console.WriteLine("invalid time");
            }
        }
    }
}
//// NOTES :
// INFO : DateTime Format :http://www.dotnetperls.com/datetime-format

//  Another solution

/*
 
            Console.Write("Enter a time in format \"hh:mm tt\" (Example: 04:32 PM) ");
            //DateTime inputTime = DateTime.Parse(Console.ReadLine());
            DateTime inputTime;
            bool inputTimeTest = DateTime.TryParse(Console.ReadLine(), out inputTime);
            int hour = inputTime.TimeOfDay.Hours;

            if (inputTimeTest)
            {  //// - problem ! in the logic - it takes only the hours ->>> ! There must be comparison depending on the minutes too
                if ((hour >= 13 && hour <= 24) || (hour >= 0 && hour <= 3))
                {
                    Console.WriteLine("beer time");
                }
                else
                    Console.WriteLine("non-beer time");
            }
            else
            {
                Console.WriteLine("invalid time");
            }
 */