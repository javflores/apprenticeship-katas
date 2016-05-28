using System.Collections.Generic;
using TicTacToe.GamePlayer;

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