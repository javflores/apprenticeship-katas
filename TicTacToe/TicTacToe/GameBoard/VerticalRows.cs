using System.Collections.Generic;

namespace TicTacToe.GameBoard
{
    public class VerticalRows : Rows
    {
        public VerticalRows()
        {
            _rows = new List<IRow>()
            {
                new VerticalRow(0),
                new VerticalRow(1),
                new VerticalRow(2)
            };
        }

        
    }
}