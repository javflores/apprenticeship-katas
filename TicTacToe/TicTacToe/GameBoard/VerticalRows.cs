using System.Collections.Generic;

namespace TicTacToe.GameBoard
{
    public class VerticalRows : Rows
    {
        private List<IRow> rows;

        protected override List<IRow> _rows =>
            rows ??
            (rows = new List<IRow>
            {
                new VerticalRow(0),
            new VerticalRow(1),
            new VerticalRow(2)
        });
    }
}