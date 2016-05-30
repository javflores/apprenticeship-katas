using TicTacToe;
using Xunit;

namespace TicTacToeTests
{
    public class TicTacToeServiceShould
    {
        private readonly TicTacToeService _ticTacToeService = new TicTacToeService();

        [Fact]
        public void return_game_in_progress_after_first_move()
        {
            Assert.Equal("In Progress", Play(0, 1));
        }

        [Fact]
        public void return_draw_when_all_possitions_were_played()
        {
            Assert.Equal("Draw", FillInBoard());
        }

        [Fact]
        public void returns_winner_when_player_has_filled_a_row()
        {
            Play(0, 0);
            Play(1, 1);
            Play(0, 1);
            Play(2, 2);

            Assert.Equal("X Win", Play(0, 2));
        }

        private string Play(int row, int column)
        {
            return _ticTacToeService.Play(row, column);
        }

        private string FillInBoard()
        {
            Play(0, 0);
            Play(0, 1);
            Play(0, 2);
            Play(1, 0);
            Play(1, 1);
            Play(1, 2);
            Play(2, 1);
            Play(2, 0);

            return _ticTacToeService.Play(2, 2);
        }
    }
}
