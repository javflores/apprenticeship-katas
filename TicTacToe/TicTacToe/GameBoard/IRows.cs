using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public interface IRows
    {
        void Add(Position position, Player player);
        Player Winner();
        bool AllFilledIn();
    }
}