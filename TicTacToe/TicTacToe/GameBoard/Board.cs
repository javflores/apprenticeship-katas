using System.Collections.Generic;
using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public class Board
    {
        private readonly Rows _rows = new Rows();
        private readonly IDictionary<Position, Player> _positions = new Dictionary<Position, Player>();

        public void Play(Position position, Player player)
        {
            _rows.Add(position, player);
            _positions.Add(position, player);
        }

        public bool AllFilledIn()
        {
            return _positions.Count == 9;
        }

        public Player Winner()
        {
            return _rows.Winner();
        }
    }
}