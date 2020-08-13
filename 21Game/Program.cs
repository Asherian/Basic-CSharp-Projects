using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace _21Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            //List<Card> newList = deck.Cards.Where(x =>x.Face == Face.King).ToList();

            List<int> numberList = new List<int>() { 1, 2, 3, 35, 535, 342, 23 };

            int sum = numberList.Where(x => x > 20).Sum() ;
            Console.WriteLine(sum);
            //deck.Shuffle(3);
            ////One object morphing into a higher order object aka something it inherts from. 
            //List<Game> games = new List<Game>();
            //TwentyOneGame game = new TwentyOneGame();
            //games.Add(game);
            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game += player;
            //    // same as typing game = game + player;
            //game -= player;

            //Card card = new Card() { Face = "King", Suit = "Spades" };
            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //int underlyingvalue = (int)Suit.Diamonds;


                foreach (Card card in deck.Cards)
                {
                    Console.WriteLine(card.Face + " of " + card.Suit);
                }
                Console.WriteLine(deck.Cards.Count);

            Console.Read();
        }


        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i=0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }


}
