using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public interface IRow
    {
        void Add(Position position, Player player);
        Player Winner();
        bool AllPositionsFilledIn();
    }
}