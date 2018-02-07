using System;

namespace Task_2
{
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
////          var hands = new int[count]; // if we need to use the cards-info

            var types = "23456789TJQKA";
            var suits = "cdhs";

            var cards = new int[52];

            ////goal 
                ////build a deck[52] - isFullDeck
                ////even number of occuring cards - in all hands

            while (count-- > 0)
            {
                // The Reverse case (array count 0->n VS bit count n <- 0) => process it as collection (IEnumerable)
                var hand = string.Join(string.Empty, Convert.ToString(long.Parse(Console.ReadLine()), 2).Reverse());

                for (int i = 0; i < hand.Length; i++)
                {
                    cards[i] += hand[i] - '0';
                }
            }

            ////isFullDeck
            var hasFullDeck = cards.Where(x => x > 0).Count() == cards.Length;
            Console.WriteLine(hasFullDeck ? "Full deck" : "Wa wa!");

            ////even N of cards
            var sb = new StringBuilder();
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] % 2 == 0)
                {
                    var typeIndex = i % types.Length;  // index inside a cycle
                    var suitsIndex = i / types.Length; // integer cycle (integer devision)
                    sb.Append(types[typeIndex] + "" + suits[suitsIndex] + " ");
                }
            }
            var result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}