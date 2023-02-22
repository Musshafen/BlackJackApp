using System;
using System.Collections.Generic;

namespace BlackJackApp
{
    class Hand
    {

        public List<Card> IndividualCards { get; set; } = new List<Card>();



        public void Receive(Card newCard)
        {
            IndividualCards.Add(newCard);
        }

        public int TotalValue()
        {

            var total = 0;

            foreach (var card in IndividualCards)
            {
                total += card.Value();
            }



            return total;
        }


    }




    class Card
    {

        public string Rank { get; set; }
        public string Suit { get; set; }


        public int Value()
        {
            var theCardValue = 0;
            if (Rank == "2")
            {
                theCardValue = 2;
            }
            else if (Rank == "3")
            {
                theCardValue = 3;
            }
            else if (Rank == "4")
            {
                theCardValue = 4;
            }
            else if (Rank == "5")
            {
                theCardValue = 5;
            }
            else if (Rank == "6")
            {
                theCardValue = 6;
            }
            else if (Rank == "7")
            {
                theCardValue = 7;
            }
            else if (Rank == "8")
            {
                theCardValue = 8;
            }
            else if (Rank == "9")
            {
                theCardValue = 9;
            }
            else if (Rank == "10")
            {
                theCardValue = 10;
            }
            else if (Rank == "Jack")
            {
                theCardValue = 10;
            }
            else if (Rank == "Queen")
            {
                theCardValue = 10;
            }
            else if (Rank == "King")
            {
                theCardValue = 10;
            }
            else if (Rank == "Ace")
            {
                theCardValue = 11;
            }



            return theCardValue;
        }

        public string Description()
        {
            var newDescriptionString = $"The {Rank} of {Suit} - worth {Value()} points. ";

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

            playerHand.Receive(newCard);

            newCard = deck[0];
            deck.Remove(newCard);

            playerHand.Receive(newCard);


            newCard = deck[0];
            deck.Remove(newCard);

            dealerHand.Receive(newCard);

            newCard = deck[0];
            deck.Remove(newCard);

            dealerHand.Receive(newCard);

            Console.WriteLine("Your cards are ");
            foreach (var card in playerHand.IndividualCards)
            {
                Console.WriteLine(card.Description());
            }
            Console.WriteLine("Your total hand value is: ");
            Console.WriteLine(playerHand.TotalValue());



        }
    }
}
