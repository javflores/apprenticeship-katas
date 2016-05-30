using TicTacToe.GamePlayer;

namespace TicTacToe.GameBoard
{
    public class Board
    {
        readonly Positions _positions = new Positions();
        readonly WinningMoves _winningMoves = new WinningMoves();

        public void Play(Position position, Player player)
        {
            _positions.Play(position, player);
        }

        public bool AllFilledIn()
        {
            return _positions.AllFilledIn();
        }

        public Player Winner()
        {
            return _winningMoves.FindWinner(_positions);
        }
    }
}