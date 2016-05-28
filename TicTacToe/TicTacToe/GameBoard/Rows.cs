using System.Collections.Generic;
using System.Linq;
using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public class Rows : IRows
    {
        protected List<IRow> _rows;

        public void Add(Position position, Player player)
        {
            _rows.ForEach(row => row.Add(position, player));
        }

        public Player Winner()
        {
            Player winner = new NoPlayer();
            for (int row = 0; winner.Equals(new NoPlayer()) && row < _rows.Count; row++)
            {
                winner = _rows[row].Winner();
            }

            return winner;
        }

        public bool AllFilledIn()
        {
            return _rows.All(row => row.AllPositionsFilledIn());
        }
    }
}