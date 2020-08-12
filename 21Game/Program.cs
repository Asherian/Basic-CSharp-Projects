using System;

namespace _21Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle(3);

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
