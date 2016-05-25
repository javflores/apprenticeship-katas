namespace TicTacToe
{
    public class Board
    {
        private readonly string _board;

        public Board(string board)
        {
            _board = board;
        }

        public override bool Equals(object another)
        {
            return ((Board)another)._board == _board;
        }
    }
}