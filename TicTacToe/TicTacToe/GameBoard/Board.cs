using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public class Board
    {
        private readonly Rows _rows = new Rows();

        public void Play(Position position, Player player)
        {
            _rows.Play(position, player);
        }

        public bool AllFilledIn()
        {
            return _rows.AllFilledIn();
        }

        public Player Winner()
        {
            return _rows.FindWinner();
        }
    }
}