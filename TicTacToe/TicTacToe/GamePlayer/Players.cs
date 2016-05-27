using System.Collections.Generic;
using System.Linq;

namespace TicTacToe.GamePlayer
{
    public class Players
    {
        private readonly List<Player> _players;

        public Players()
        {
            _players = new List<Player>
            {
                new PlayerO(),
                new PlayerX()
            };
        }

        public Player Swap()
        {
            _players.Reverse();
            return _players.First();
        }
    }
}