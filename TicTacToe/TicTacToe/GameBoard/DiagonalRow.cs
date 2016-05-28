using System.Collections.Generic;
using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public class DiagonalRow : Row
    {
        public DiagonalRow(int diagonal)
        {
            _positions = diagonal == 0
                ? FirstDiagonal()
                : SecondDiagonal();
        }

        private Dictionary<Position, Player> FirstDiagonal()
        {
            return new Dictionary<Position, Player>()
            {
                { new Position(0, 0), new NoPlayer()},
                { new Position(1, 1), new NoPlayer()},
                { new Position(2, 2), new NoPlayer()}
            };
        }

        private Dictionary<Position, Player> SecondDiagonal()
        {
            return new Dictionary<Position, Player>()
            {
                { new Position(0, 2), new NoPlayer()},
                { new Position(1, 1), new NoPlayer()},
                { new Position(2, 0), new NoPlayer()}
            };
        }
    }
}