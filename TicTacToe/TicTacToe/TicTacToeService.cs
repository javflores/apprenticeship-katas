namespace TicTacToe
{
    public class TicTacToeService
    {
        private readonly Positions _positions = new Positions();
        private readonly Players _players = new Players();

        public GameResult Play(Position position)
        {
            var currentPlayer = _players.Swap();

            _positions.Play(position, currentPlayer);

            if (_positions.AllFilledIn())
            {
                return GameResult.Draw;
            }

            var winner = _positions.Winner();
            if (winner != null)
            {
                return GameResult.XWin;
            }

            return GameResult.InProgress;
        }
    }
}
