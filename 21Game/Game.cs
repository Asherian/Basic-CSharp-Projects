using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Game
{
    public abstract class Game
    //abstract class - can only be inhereted from, can never be an object itself. Also known as a Base Class
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        public abstract void Play();
        //can only exist inside an abstract class, and allows no insitiation.
        //Any class inherting this class will have to have this method.

        public virtual void ListPlayers()
            //virtual is only inside of an abstract class, can be inherted by a class to be overriden.
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
