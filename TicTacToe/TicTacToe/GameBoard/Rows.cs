using System.Collections.Generic;
using System.Linq;
using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public abstract class Rows : IRows
    {
        protected abstract List<IRow> _rows { get; }

        public void Play(Position position, Player player)
        {
            _rows.ForEach(row => row.Play(position, player));
        }

        public Player Winner()
        {
            Player winner = new NoPlayer();
            for (int row = 0; NoWinnerYet(winner) && row < _rows.Count; row++)
            {
                winner = _rows[row].Winner();
            }

            return winner;
        }

        public bool AllFilledIn()
        {
            return _rows.All(row => row.AllPositionsFilledIn());
        }

        private bool NoWinnerYet(Player winner)
        {
            return winner.Equals(new NoPlayer());
        }
    }
}