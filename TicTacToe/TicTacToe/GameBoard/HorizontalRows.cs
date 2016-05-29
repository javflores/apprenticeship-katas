using System.Collections.Generic;

namespace TicTacToe.GameBoard
{
    public class HorizontalRows : Rows
    {
        private List<IRow> rows;

        protected override List<IRow> _rows => 
            rows ?? 
            (rows = new List<IRow>
            {
                new HorizontalRow(0),
                new HorizontalRow(1),
                new HorizontalRow(2)
        });
    }
}