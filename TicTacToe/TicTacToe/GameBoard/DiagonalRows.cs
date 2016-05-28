using System.Collections.Generic;

namespace TicTacToe.GameBoard
{
    public class DiagonalRows : Rows
    {
        public DiagonalRows()
        {
            _rows = new List<IRow>()
            {
                new DiagonalRow(0),
                new DiagonalRow(1)
            };
        }
    }
}