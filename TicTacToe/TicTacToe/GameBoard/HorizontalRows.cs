using System.Collections.Generic;
using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public class HorizontalRows
    {
        private List<HorizontalRow> _rows;

        public HorizontalRows()
        {
            _rows = new List<HorizontalRow>()
            {
                new HorizontalRow(0),
                new HorizontalRow(1),
                new HorizontalRow(2)
            };
        }

        public void Add(Position position, Player player)
        {
            _rows.ForEach(row => row.Add(position, player));
        }

        public Player Winner()
        {
            Player winner = new NoPlayer();
            for (int row = 0; winner.Equals(new NoPlayer()) && row < 3 ; row++)
            {
                winner = _rows[row].Winner();
            }

            return winner;
        }
    }
}