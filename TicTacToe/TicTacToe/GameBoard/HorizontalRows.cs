using System.Collections.Generic;

namespace TicTacToe.GameBoard
{
    public class HorizontalRows : Rows
    {
        public HorizontalRows()
        {
            _rows = new List<IRow>()
            {
                new HorizontalRow(0),
                new HorizontalRow(1),
                new HorizontalRow(2)
            };
        }
    }
}