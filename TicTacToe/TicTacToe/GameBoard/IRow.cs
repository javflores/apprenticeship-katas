using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public interface IRow
    {
        void Play(Position position, Player player);
        Player Winner();
        bool AllPositionsFilledIn();
    }
}