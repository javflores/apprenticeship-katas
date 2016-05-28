using System.Collections.Generic;
using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public class VerticalRows
    {
        private List<IRow> _columns;

        public VerticalRows()
        {
            _columns = new List<IRow>()
            {
                new VerticalRow(0),
                new VerticalRow(1),
                new VerticalRow(2)
            };
        }

        public void Add(Position position, Player player)
        {
            _columns.ForEach(column => column.Add(position, player));
        }

        public Player Winner()
        {
            Player winner = new NoPlayer();
            for (int column = 0; winner.Equals(new NoPlayer()) && column < 3; column++)
            {
                winner = _columns[column].Winner();
            }

            return winner;
        }
    }
}