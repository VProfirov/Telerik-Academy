/*Problem 9.	Play with Int, Double and String
Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends "*" at the end.
Print the result at the console. Use switch statement.
 * Example:
 program	                user
Please choose a type:       3
1 --> int
2 --> double
3 --> string	            

Please enter a string:	hello
hello*	

 */
namespace PlayWithIntDoubleString
{
    using System;

    class PlayWithIntDoubleString
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            Console.WriteLine();
            sbyte choice = sbyte.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Please enter an integer: ");
                    int firstCohise = int.Parse(Console.ReadLine());
                    //// Console.WriteLine() plays only presentational role for the Console
                    Console.WriteLine();
                    Console.WriteLine(firstCohise + 1);
                    break;
                case 2:
                    Console.Write("Please enter a double: ");
                    double secondCohise = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine(secondCohise + 1);
                    break;
                case 3:
                    Console.Write("Please enter a string: ");
                    string thirdCohise = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(thirdCohise + "*");
                    break;
                default:
                    Console.WriteLine("Problem, problem !");
                    break;
            }
            Console.WriteLine();
        }
    }
}
//// NOTES : Another solutions

/*  SIMPLer/sloppy SOLUTION
 * 
            Console.Write("Enter 1 for int, 2 for double, and 3 for string : ");
            sbyte choice = sbyte.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter some input depending of your preview choice: ");
            Console.WriteLine();

            switch (choice)
            {
                case 1: int firstCohise = int.Parse(Console.ReadLine());
                    Console.WriteLine(firstCohise + 1);
                    break;
                case 2: double secondCohise = double.Parse(Console.ReadLine());
                    Console.WriteLine(secondCohise + 1);
                    break;
                case 3: string thirdCohise = Console.ReadLine();
                    Console.WriteLine(thirdCohise + "*");
                    break;
                default: Console.WriteLine("Problem, problem");
                    break;
            }
            Console.WriteLine();
 */
