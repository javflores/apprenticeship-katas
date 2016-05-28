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
        private readonly IDictionary<Position, Player> _positions = new Dictionary<Position, Player>();

        public void Play(Position position, Player player)
        {
            _rows.ForEach(rows => rows.Add(position, player));
            _positions.Add(position, player);
        }

        public bool AllFilledIn()
        {
            return _positions.Count == 9;
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