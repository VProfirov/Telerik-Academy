/*Problem 3.	Check for a Play Card
Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 
 * Examples:
character	Valid card sign?
5	            yes
1	            no
Q	            yes
q	            no
P	            no
10	            yes
500	            no

 */
namespace ExchangeIfGreater
{
    using System;

    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.Write("Enter a sign for a play card : ");
            string signOfPlayCard = Console.ReadLine();

            int number ;
            bool ifNumber = int.TryParse(signOfPlayCard, out number);

            if (ifNumber&&((number>=2)&&(number<=10)))
            {
                Console.WriteLine("yes");
            }
            else if (signOfPlayCard == "a" || signOfPlayCard == "A")
            {
                Console.WriteLine("yes");
            }
            else if (signOfPlayCard == "j" || signOfPlayCard == "J")
            {
                Console.WriteLine("yes");                
            }
            else if (signOfPlayCard == "q" || signOfPlayCard == "Q")
            {
                Console.WriteLine("yes");                
            }
            else if (signOfPlayCard == "k" || signOfPlayCard == "K")
            {
                Console.WriteLine("yes");                
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
