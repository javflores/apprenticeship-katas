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

        public void Play(Position position, Player player)
        {
            _rows.ForEach(rows => rows.Add(position, player));
        }

        public bool AllFilledIn()
        {
            return _rows.All(row => row.AllFilledIn());
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