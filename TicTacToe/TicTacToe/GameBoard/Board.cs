using System.Collections.Generic;
using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public class Board
    {
        private readonly Rows _rows = new Rows();
        private readonly Columns _columns = new Columns();
        private readonly IDictionary<Position, Player> _positions = new Dictionary<Position, Player>();

        public void Play(Position position, Player player)
        {
            _rows.Add(position, player);
            _columns.Add(position, player);
            _positions.Add(position, player);
        }

        public bool AllFilledIn()
        {
            return _positions.Count == 9;
        }

        public Player Winner()
        {
            var winner = _rows.Winner();
            if (!winner.Equals(new NoPlayer()))
            {
                return winner;
            }

            return _columns.Winner();
        }
    }
}