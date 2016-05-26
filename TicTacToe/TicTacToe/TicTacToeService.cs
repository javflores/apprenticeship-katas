namespace TicTacToe
{
    public class TicTacToeService
    {
        private readonly Board _board;

        public TicTacToeService()
        {
            _board = new Board();
        }
        public Board Play(Position position)
        {
            _board.Played(position);
            return _board;
        }
    }
}
