using System.Collections.Generic;

namespace TicTacToe
{
    public class Board
    {
        private readonly IList<Position> _positions;

        public Board()
        {
            _positions = new List<Position>();
        }

        public void Played(Position position)
        {
            _positions.Add(position);
        }

        public override string ToString()
        {
            if (_positions.Contains(new Position(0, 1)))
            {
                return "-X-------";
            }

            if (_positions.Contains(new Position(0, 2)))
            {
                return "--X------";
            }

            return "X--------";
        }


    }
}