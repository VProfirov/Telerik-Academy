/* Print a Deck* ( Version: up until a card)
     Write a program that reads a card sign(as a string) from the console and generates and prints all
     possible cards from a standard deck of 52 cards up to the card with the given sign(without the jokers).
     The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs;
     and K of diamonds).
     */
namespace PrintDeckOf52Cards
{
    using System;

    class PrintDeckOf52Cards
    {
        static void Main()
        {
            string[] deck = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A", };
            string card = Console.ReadLine().ToUpper();
            for (int i = 0; i < deck.Length; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", deck[i]);
                if (deck[i] == card)
                {
                    break;
                }
            }

            ////To use the Hack Literal Solution comment the top-side code and uncomment the one below
            // TheLitteralHackSolution.HackSolution();
        }
    }

    class TheLitteralHackSolution
    {
        public static void HackSolution()
        {
            // string input = Console.ReadLine().ToUpper();
            // char c = input[0];
            // ...or use the ToUpper Check section

            ////after reading just the 1st symbol, considers the 10 as 1 and use it as a compare marker
            string cards = "234567891JQKA";
            int holder = 0;
            int counter = 1;

            ////ToUpper Check
            char c = (char)Console.Read();
            if (c > 'Z')
            {
                ////in ASCII the Upper Letters have lower decimal value
                cards = cards.ToLower();
            }

            ////finds the numberic position of the
            foreach (var card in cards)
            {
                counter++;
                if (card == c)
                {
                    break;
                }
            }

            for (int i = 2; i <= counter; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    switch (i)
                    {
                        case 2:
                            Console.Write("2 of ");
                            break;
                        case 3:
                            Console.Write("3 of ");
                            break;
                        case 4:
                            Console.Write("4 of ");
                            break;
                        case 5:
                            Console.Write("5 of ");
                            break;
                        case 6:
                            Console.Write("6 of ");
                            break;
                        case 7:
                            Console.Write("7 of ");
                            break;
                        case 8:
                            Console.Write("8 of ");
                            break;
                        case 9:
                            Console.Write("9 of ");
                            break;
                        case 10:
                            Console.Write("10 of ");
                            break;
                        case 11:
                            Console.Write("J of ");
                            break;
                        case 12:
                            Console.Write("Q of ");
                            break;
                        case 13:
                            Console.Write("K of ");
                            break;
                        case 14:
                            Console.Write("A of ");
                            break;
                        default:
                            Console.WriteLine("Houston we have a problem!");
                            break;
                    }

                    switch (j)
                    {
                        case 1:
                            Console.Write("spades, ");
                            break;
                        case 2:
                            Console.Write("clubs, ");
                            break;
                        case 3:
                            Console.Write("hearts, ");
                            break;
                        case 4:
                            Console.WriteLine("diamonds");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                }
            }
        }
    }

    /*Problem 4.	Print a Deck of 52 Cards
    Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
    The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦).
    The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
    Use 2 nested for-loops and a switch-case statement.
    */
    class PrintEntireDeck
    {
        public static void Solution()
        {
            for (int i = 2; i < 15; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    switch (i)
                    {
                        case 2:
                            Console.Write("Two of");
                            break;
                        case 3:
                            Console.Write("Three of");
                            break;
                        case 4:
                            Console.Write("Four of");
                            break;
                        case 5:
                            Console.Write("Five of");
                            break;
                        case 6:
                            Console.Write("Six of");
                            break;
                        case 7:
                            Console.Write("Seven of");
                            break;
                        case 8:
                            Console.Write("Eight of");
                            break;
                        case 9:
                            Console.Write("Nine of");
                            break;
                        case 10:
                            Console.Write("Ten of");
                            break;
                        case 11:
                            Console.Write("King of");
                            break;
                        case 12:
                            Console.Write("Queen of");
                            break;
                        case 13:
                            Console.Write("Knave of");
                            break;
                        case 14:
                            Console.Write("Ace of");
                            break;
                        default:
                            Console.WriteLine("Houston we have a problem!");
                            break;
                    }

                    switch (j)
                    {
                        case 1:
                            Console.Write(" Spades");
                            break;
                        case 2:
                            Console.Write(" Hearts");
                            break;
                        case 3:
                            Console.Write(" Diamonds");
                            break;
                        case 4:
                            Console.Write(" Clubs");
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}