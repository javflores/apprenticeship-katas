using System.Collections.Generic;

namespace TicTacToe
{
    public class TicTacToeService
    {
        private readonly IList<Position> _positions = new List<Position>();

        public GameResult Play(Position position)
        {
            _positions.Add(position);

            if (_positions.Count == 9)
            {
                return GameResult.Draw;
            }

            return GameResult.InProgress;
        }
    }
}
