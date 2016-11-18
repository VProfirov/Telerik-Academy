﻿namespace NinjaAssassins.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using NinjaAssassins.Helper;
    using NinjaAssassins.Models.Cards;

    public class Deck : IEnumerable<Card>, IDeck
    {
        private const string OutOfRangeExceptionMsg = "Index is out of range.";

        private static Random random = new Random();
        private List<Card> deck;

        public Deck()
        {
            this.deck = new List<Card>();
            this.FillDeck(Constants.CardsInDeck);
            this.deck = this.Shuffle();
        }

        public int Count
        {
            get
            {
                return this.deck.Count;
            }
        }

        public void Add(Card card)
        {
            this.deck.Add(card);
        }

        public void Insert(int index, Card card)
        {
            this.deck.Insert(index, card);
        }

        public void Clear()
        {
            this.deck.Clear();
        }

        public List<Card> Shuffle()
        {
            return (List<Card>)this.deck
                .OrderBy<Card, int>((item) => random.Next())
                .ToList();
        }

        public void FillDeck(int cardsInDeck)
        {
            int allCardTypesCount = Enum.GetValues(typeof(CardType)).Length;

            Card card;
            for (int i = 1; i <= allCardTypesCount; i++)
            {
                for (int j = 0; j < cardsInDeck / allCardTypesCount; j++)
                {
                    CardType cardType = (CardType)i;
                    card = CardFactory.Get(cardType);
                    this.deck.Add(card);
                }
            }

            // add additional Ninja Assassin cards?
            // for (int i = 0; i < cardsInDeck / allCardTypesCount; i++)
            // {
            //     card = CardFactory.Get(CardType.NinjaAssassin);
            //     this.deck.Add(card);
            // }
        }

        public void RemoveCardFromDeck(Card card)
        {
            int cardIndex = this.deck.IndexOf(card);
            this.deck.RemoveAt(cardIndex);
        }

        public Card this[int index]
        {
            get
            {
                return this.deck[index];
            }

            set
            {
                if (index < 0 || index >= this.deck.Count - 1)
                {
                    throw new IndexOutOfRangeException(OutOfRangeExceptionMsg);
                }

                this.deck[index] = value;
            }
        }

        public IEnumerator<Card> GetEnumerator()
        {
            return this.deck.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.deck.GetEnumerator();
        }
    }
}
