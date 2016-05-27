using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class Players
    {
        private readonly List<Player> _players;

        public Players()
        {
            _players = new List<Player>
            {
                new Player("O"),
                new Player("X")
            };
        }

        public Player Swap()
        {
            _players.Reverse();
            return _players.First();
        }
    }
}