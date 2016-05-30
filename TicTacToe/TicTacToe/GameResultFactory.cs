using TicTacToe.GameBoard;
using TicTacToe.GamePlayer;

namespace TicTacToe
{
    public class GameResultFactory
    {
        public static string Evaluate(Board board)
        {
            var winner = board.Winner();
            if (!winner.Equals(Player.NoPlayer))
            {
                return winner.Equals(Player.X) ? "X Win" : "O Win";
            }

            if (board.AllFilledIn())
            {
                return "Draw";
            }

            return "In Progress";
        }
    }
}