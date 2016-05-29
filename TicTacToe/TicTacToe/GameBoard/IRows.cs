using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public interface IRows
    {
        void Play(Position position, Player player);
        Player Winner();
        bool AllFilledIn();
    }
}