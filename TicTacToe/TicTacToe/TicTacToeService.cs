using TicTacToe.GameBoard;
using TicTacToe.GamePlayer;

namespace TicTacToe
{
    public class TicTacToeService
    {
        private readonly Board _board = new Board();
        private readonly Players _players = new Players();

        public string Play(int row, int column)
        {
            var currentPlayer = _players.Swap();

            _board.Play(new Position(row, column), currentPlayer);

            return Result();
        }

        private string Result()
        {
            if (_board.AllFilledIn())
            {
                return "Draw";
            }

            var player = _board.Winner();
            return player.AsWinner();
        }
    }
}
