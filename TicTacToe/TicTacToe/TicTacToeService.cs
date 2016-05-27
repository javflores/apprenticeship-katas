using TicTacToe.GameBoard;
using TicTacToe.GamePlayer;

namespace TicTacToe
{
    public class TicTacToeService
    {
        private readonly Board _board = new Board();
        private readonly Players _players = new Players();

        public GameResult Play(Position position)
        {
            var currentPlayer = _players.Swap();

            _board.Play(position, currentPlayer);

            if (_board.AllFilledIn())
            {
                return GameResult.Draw;
            }

            var winner = _board.Winner();
            if (winner.Equals(new NoPlayer()))
            {
                return GameResult.InProgress;
            }

            if (winner.Equals(new PlayerX()))
            {
                return GameResult.XWin;
            }

            return GameResult.OWin;
        }
    }
}
