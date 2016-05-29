using System.Collections.Generic;

namespace TicTacToe.GameBoard
{
    public class DiagonalRows : Rows
    {
        private List<IRow> rows;

        protected override List<IRow> _rows =>
            rows ??
            (rows = new List<IRow>
            {
                new DiagonalRow(0),
                new DiagonalRow(1)
            });
    }
}