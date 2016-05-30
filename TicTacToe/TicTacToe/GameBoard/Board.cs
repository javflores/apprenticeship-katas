using System.Collections.Generic;
using System.Linq;
using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public class Board
    {
        private readonly List<IRows> _rows = new List<IRows>
        {
            new HorizontalRows(),
            new VerticalRows(),
            new DiagonalRows()
        };

        private Dictionary<Position, Player> _positions = new Dictionary<Position, Player>()
            {
                { new Position(0, 0), new NoPlayer()},
                { new Position(0, 1), new NoPlayer()},
                { new Position(0, 2), new NoPlayer()},
                { new Position(1, 0), new NoPlayer()},
                { new Position(1, 1), new NoPlayer()},
                { new Position(1, 2), new NoPlayer()},
                { new Position(2, 0), new NoPlayer()},
                { new Position(2, 1), new NoPlayer()},
                { new Position(2, 2), new NoPlayer()}
            };

        public void Play(Position position, Player player)
        {
            _positions[position] = player;

            _rows.ForEach(rows => rows.Play(position, player));
        }

        public bool AllFilledIn()
        {
            return _positions.All(position => !position.Value.Equals(new NoPlayer()));
        }

        public Player Winner()
        {
            return _rows
                .Select(rows => rows.Winner())
                .Where(result => !result.Equals(new NoPlayer()))
                .DefaultIfEmpty(new NoPlayer())
                .SingleOrDefault();
        }
    }
}