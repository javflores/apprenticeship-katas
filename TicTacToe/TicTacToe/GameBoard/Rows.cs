using System.Collections.Generic;
using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public class Rows : IRows
    {
        protected List<IRow> _rows;

        public void Add(Position position, Player player)
        {
            _rows.ForEach(column => column.Add(position, player));
        }

        public Player Winner()
        {
            Player winner = new NoPlayer();
            for (int column = 0; winner.Equals(new NoPlayer()) && column < 3; column++)
            {
                winner = _rows[column].Winner();
            }

            return winner;
        }
    }
}