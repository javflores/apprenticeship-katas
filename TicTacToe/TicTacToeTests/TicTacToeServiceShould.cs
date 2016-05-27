using TicTacToe;
using Xunit;

namespace TicTacToeTests
{
    public class TicTacToeServiceShould
    {
        [Fact]
        public void return_game_in_progress_after_first_move()
        {
            var position = new Position(0, 1);

            GameResult result = new TicTacToeService().Play(position);

            Assert.Equal(GameResult.InProgress, result);
        }

        [Fact]
        public void return_draw_when_all_possitions_were_played()
        {
            var ticTacToeService = new TicTacToeService();

            ticTacToeService.Play(new Position(0, 0));
            ticTacToeService.Play(new Position(0, 1));
            ticTacToeService.Play(new Position(0, 2));
            ticTacToeService.Play(new Position(1, 0));
            ticTacToeService.Play(new Position(1, 1));
            ticTacToeService.Play(new Position(1, 2));
            ticTacToeService.Play(new Position(2, 0));
            ticTacToeService.Play(new Position(2, 1));

            GameResult result = ticTacToeService.Play(new Position(2, 2));

            Assert.Equal(GameResult.Draw, result);

        }
    }
}
