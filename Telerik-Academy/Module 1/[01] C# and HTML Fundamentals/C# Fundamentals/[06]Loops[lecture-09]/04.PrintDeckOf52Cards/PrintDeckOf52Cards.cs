/*Problem 4.	Print a Deck of 52 Cards
Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
 The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦).
 The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
 Use 2 nested for-loops and a switch-case statement.

 */
namespace PrintDeckOf52Cards
{
    using System;

    class PrintDeckOf52Cards
    {
        static void Main()
        {
            for (int i = 2; i < 15; i++)
            {

                for (int j = 1; j < 5; j++)
                {
                    switch (i)
                    {
                        case 2: Console.Write("Two of");
                            break;
                        case 3: Console.Write("Three of");
                            break;
                        case 4: Console.Write("Four of");
                            break;
                        case 5: Console.Write("Five of");
                            break;
                        case 6: Console.Write("Six of");
                            break;
                        case 7: Console.Write("Seven of");
                            break;
                        case 8: Console.Write("Eight of");
                            break;
                        case 9: Console.Write("Nine of");
                            break;
                        case 10: Console.Write("Ten of");
                            break;
                        case 11: Console.Write("King of");
                            break;
                        case 12: Console.Write("Queen of");
                            break;
                        case 13: Console.Write("Knave of");
                            break;
                        case 14: Console.Write("Ace of");
                            break;
                        default: Console.WriteLine("Houston we have a problem!");
                            break;
                    }
                    switch (j)
                    {
                        case 1: Console.Write(" Spades");
                            break;
                        case 2: Console.Write(" Hearts");
                            break;
                        case 3: Console.Write(" Diamonds");
                            break;
                        case 4: Console.Write(" Clubs");
                            break;
                        default: Console.WriteLine("Error");
                            break;
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
