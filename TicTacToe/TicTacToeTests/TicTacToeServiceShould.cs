using TicTacToe;
using TicTacToe.GameBoard;
using Xunit;

namespace TicTacToeTests
{
    public class TicTacToeServiceShould
    {
        private readonly TicTacToeService _ticTacToeService = new TicTacToeService();

        [Fact]
        public void return_game_in_progress_after_first_move()
        {
            var position = new Position(0, 1);

            GameResult result = _ticTacToeService.Play(position);

            Assert.Equal(GameResult.InProgress, result);
        }

        [Fact]
        public void return_draw_when_all_possitions_were_played()
        {
            Play(0, 0);
            Play(0, 1);
            Play(0, 2);
            Play(1, 0);
            Play(1, 1);
            Play(1, 2);
            Play(2, 0);
            Play(2, 1);

            GameResult result = _ticTacToeService.Play(new Position(2, 2));

            Assert.Equal(GameResult.Draw, result);
        }

        [Fact]
        public void returns_X_as_winner_when_has_filled_in_first_row()
        {
            Play(0, 0);
            Play(1, 1);
            Play(0, 1);
            Play(2, 2);

            GameResult result = _ticTacToeService.Play(new Position(0, 2));

            Assert.Equal(GameResult.XWin, result);
        }

        [Fact]
        public void returns_O_as_winner_when_has_filled_in_first_row()
        {
            Play(1, 1);
            Play(0, 0);
            Play(2, 2);
            Play(0, 1);
            Play(2, 1);

            GameResult result = _ticTacToeService.Play(new Position(0, 2));

            Assert.Equal(GameResult.OWin, result);
        }

        [Fact]
        public void returns_X_as_winner_when_has_filled_in_first_column()
        {
            Play(0, 0);
            Play(1, 1);
            Play(1, 0);
            Play(2, 2);

            GameResult result = _ticTacToeService.Play(new Position(2, 0));

            Assert.Equal(GameResult.XWin, result);
        }

        private void Play(int row, int column)
        {
            _ticTacToeService.Play(new Position(row, column));
        }
    }
}
