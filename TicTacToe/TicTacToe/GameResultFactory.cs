using TicTacToe.GameBoard;
using TicTacToe.GamePlayer;

namespace TicTacToe
{
    public class GameResultFactory
    {
        public static string Evaluate(Board board)
        {
            if (board.AllFilledIn())
            {
                return "Draw";
            }

            var winner = board.Winner();
            if (winner.Equals(Player.NoPlayer))
            {
                return "In Progress";
            }

            return winner.Equals(Player.X) ? "X Win" : "O Win";
        }
    }
}