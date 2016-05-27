using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class Positions
    {
        private readonly IDictionary<Position, Player> _positions = new Dictionary<Position, Player>();

        public void Play(Position position, Player player)
        {
            _positions.Add(position, player);
        }

        public bool AllFilledIn()
        {
            return _positions.Count == 9;
        }

        public Player Winner()
        {
            var positionsPlayedByX = _positions.Where(position => position.Value.Equals(new Player("X")));
            return positionsPlayedByX.Count() == 3 ? positionsPlayedByX.First().Value : null;
        }
    }
}