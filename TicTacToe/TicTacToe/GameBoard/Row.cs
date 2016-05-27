using System.Collections.Generic;
using System.Linq;
using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public class Row
    {
        private Dictionary<Position, Player> _positions;

        public Row(int row)
        {
            _positions = new Dictionary<Position, Player>()
            {
                { new Position(row, 0), new NoPlayer()},
                { new Position(row, 1), new NoPlayer()},
                { new Position(row, 2), new NoPlayer()}
            };
        }

        public void Add(Position position, Player player)
        {
            var positionInRow = _positions.SingleOrDefault(p => p.Key.Equals(position));

            if (positionInRow.Value != null)
                _positions[position] = player;
        }

        public Player Winner()
        {
            var winner = _positions
                .GroupBy(position => position.Value)
                .Where(position => position.Count() == 3)
                .Select(position => position.Key)
                .DefaultIfEmpty(new NoPlayer())
                .SingleOrDefault();

            return winner;
        }
    }
}