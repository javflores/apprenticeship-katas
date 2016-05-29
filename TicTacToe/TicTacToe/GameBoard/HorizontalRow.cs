using System.Collections.Generic;
using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public class HorizontalRow : Row
    {
        protected override Dictionary<Position, Player> _positions { get; }

        public HorizontalRow(int row)
        {
            _positions = new Dictionary<Position, Player>()
            {
                { new Position(row, 0), new NoPlayer()},
                { new Position(row, 1), new NoPlayer()},
                { new Position(row, 2), new NoPlayer()}
            };
        }
    }
}