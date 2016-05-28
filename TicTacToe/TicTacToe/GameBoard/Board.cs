using System.Collections.Generic;
using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public class Board
    {
        private readonly HorizontalRows _horizontalRows = new HorizontalRows();
        private readonly VerticalRows _verticalRows = new VerticalRows();
        private readonly IDictionary<Position, Player> _positions = new Dictionary<Position, Player>();

        public void Play(Position position, Player player)
        {
            _horizontalRows.Add(position, player);
            _verticalRows.Add(position, player);
            _positions.Add(position, player);
        }

        public bool AllFilledIn()
        {
            return _positions.Count == 9;
        }

        public Player Winner()
        {
            var winner = _horizontalRows.Winner();
            if (!winner.Equals(new NoPlayer()))
            {
                return winner;
            }

            return _verticalRows.Winner();
        }
    }
}