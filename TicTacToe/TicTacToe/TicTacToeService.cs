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

            return Result();
        }

        private GameResult Result()
        {
            if (_board.AllFilledIn())
            {
                return GameResult.Draw;
            }

            var player = _board.Winner();
            return player.AsWinner();
        }
    }
}
