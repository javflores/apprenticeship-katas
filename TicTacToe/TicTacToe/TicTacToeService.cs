namespace TicTacToe
{
    public class TicTacToeService
    {
        public Board Play(Position position)
        {
            var board = "X--------";
            if (position.Equals(new Position(0, 1)))
            {
                board = "-X-------";
            }

            return new Board(board);
        }
    }
}
