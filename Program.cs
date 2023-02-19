using System;
using System.Collections.Generic;

namespace BlackJackApp
{
    class Hand
    {

        public List<Card> IndividualCards { get; set; } = new List<Card>();



        public void Add(Card newCard)
        {
            IndividualCards.Add(newCard);
        }
    }




    class Card
    {

        public string Rank { get; set; }
        public string Suit { get; set; }


        public int Value()
        {
            return 0;
        }

        public string Description()
        {
            var newDescriptionString = $"The {Rank} of {Suit}";

            return newDescriptionString;

        }



    }



    class Program
    {
        static void Main(string[] args)
        {

            var deck = new List<Card>();

            var suits = new List<string>() { "Spades", "Clubs", "Diamonds", "Hearts" };
            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };


            foreach (var suit in suits)
            {

                foreach (var rank in ranks)
                {
                    var card = new Card { Suit = suit, Rank = rank };
                    deck.Add(card);

                }

            }

            var numberOfCards = deck.Count;

            for (var rightIndex = numberOfCards - 1; rightIndex >= 1; rightIndex--)
            {
                var randomNumberGenerator = new Random();
                var leftIndex = randomNumberGenerator.Next(rightIndex);


                var leftCard = deck[leftIndex];
                var rightCard = deck[rightIndex];
                deck[rightIndex] = leftCard;
                deck[leftIndex] = rightCard;

            }

            var playerHand = new Hand();


            var dealerHand = new Hand();

            var newCard = deck[0];
            deck.Remove(newCard);

            Console.WriteLine(newCard.Description());

            playerHand.Add(newCard);

            var playerHandCards = playerHand.IndividualCards;
            foreach(var card in playerHandCards)
            {
              Console.WriteLine(card.Description());
            }

        }
    }
}
