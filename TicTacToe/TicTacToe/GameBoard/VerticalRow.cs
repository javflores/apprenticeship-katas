using System.Collections.Generic;
using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public class VerticalRow : Row
    {
        public VerticalRow(int column)
        {
            _positions = new Dictionary<Position, Player>()
            {
                { new Position(0, column), new NoPlayer()},
                { new Position(1, column), new NoPlayer()},
                { new Position(2, column), new NoPlayer()}
            };
        }
    }
}