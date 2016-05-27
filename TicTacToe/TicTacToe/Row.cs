using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
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
            var players = _positions.Select(position => position.Value);
            if (players.All(player => player.Equals(new PlayerX())))
            {
                return new PlayerX();
            }

            if (players.All(player => player.Equals(new PlayerO())))
            {
                return new PlayerO();
            }

            return new NoPlayer();
        }
    }
}