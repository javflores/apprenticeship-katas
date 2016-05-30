using System.Collections.Generic;
using System.Linq;
using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public class Row
    {
        private readonly Dictionary<Position, Player> _positions = new Dictionary<Position, Player>();

        public Row(Position firstPosition, Position secondPosition, Position thirdPosition)
        {
            _positions.Add(firstPosition, Player.NoPlayer);
            _positions.Add(secondPosition, Player.NoPlayer);
            _positions.Add(thirdPosition, Player.NoPlayer);
        }

        public void Play(Position position, Player player)
        {
            if (_positions.ContainsKey(position))
            {
                _positions[position] = player;
            }
        }

        public bool AllFilledIn()
        {
            return _positions.All(position => !position.Value.Equals(Player.NoPlayer));
        }

        public Player Winner()
        {
            return _positions
                .GroupBy(positionsByPlayer => positionsByPlayer.Value)
                .Where(positionsByPlayer => positionsByPlayer.Count() == 3)
                .Select(positionsByPlayer => positionsByPlayer.Key)
                .DefaultIfEmpty(Player.NoPlayer)
                .SingleOrDefault();
        }
    }
}