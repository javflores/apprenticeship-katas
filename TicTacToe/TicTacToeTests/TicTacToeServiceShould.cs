using TicTacToe;
using Xunit;

namespace TicTacToeTests
{
    public class TicTacToeServiceShould
    {
        [Theory]
        [InlineData(0, 0, "X--------")]
        public void return_board_with_first_played_position(int row, int column, string expectedGame)
        {
            string board = new TicTacToeService().Play(0, 0);

            Assert.Equal(expectedGame, board);
        }
    }
}
